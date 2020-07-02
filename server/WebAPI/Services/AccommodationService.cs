using System;
using AutoMapper;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.Configuration.Conventions;
using Entities.Models.Enums;
using WebAPI.DTO;
using WebAPI.DTO.Accommodation;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public class AccommodationService
  {
    private readonly IMapper _mapper;
    private readonly AccommodationRepository _accommodationRepository;
    private readonly AssetsService _assetsService;

    public AccommodationService(
      IMapper mapper,
      AccommodationRepository accommodationRepository,
      AssetsService assetsService
      )
    {
      _mapper = mapper;
      _accommodationRepository = accommodationRepository;
      _assetsService = assetsService;
    }

    private IQueryable<Accommodation> PaginateAccommodations(IQueryable<Accommodation> accommodations, PaginationRequestQueryDTO paginationRequestQueryDto)
    {
      return accommodations
        .Skip((int)(paginationRequestQueryDto.PageNumber * paginationRequestQueryDto.PageSize))
        .Take((int)paginationRequestQueryDto.PageSize);
    }

    private IQueryable<Accommodation> SortAccommodations(IQueryable<Accommodation> accommodations, AccommodationSortingQueryDTO accommodationSortingQuery)
    {
      Func<System.Linq.Expressions.Expression<Func<Accommodation, object>>, IOrderedQueryable<Accommodation>> orderFunc;

      if (accommodationSortingQuery.SortDirection == SortDirection.Ascending)
      {
        orderFunc = accommodations.OrderBy;
      }
      else
      {
        orderFunc = accommodations.OrderByDescending;
      }

      if (accommodationSortingQuery.SortByBy == AccommodationSortBy.ByReservationDate)
      {
        return orderFunc(accommodation => accommodation.ArrivalDateTime);
      }

      if (accommodationSortingQuery.SortByBy == AccommodationSortBy.ByCostPerNight)
      {
        return orderFunc(accommodation => accommodation.Price);
      }

      return orderFunc(accommodation => accommodation.Name);
    }

    public PagedResponse<AccommodationDTO> GetAccommodations(int userId,
      PaginationRequestQueryDTO paginationRequestQuery, AccommodationSortingQueryDTO accommodationSortingQuery)
    {
      var accommodations = _accommodationRepository.GetUserAccommodations(userId);
      int totalCount = (int)Math.Ceiling(accommodations.Count() / (double)paginationRequestQuery.PageSize);
      accommodations = SortAccommodations(accommodations, accommodationSortingQuery);
      accommodations = PaginateAccommodations(accommodations, paginationRequestQuery);

      return new PagedResponse<AccommodationDTO>
      {
        Data = _mapper.Map<IEnumerable<AccommodationDTO>>(accommodations.ToList()),
        PageSize = paginationRequestQuery.PageSize,
        PageNumber = paginationRequestQuery.PageNumber,
        TotalCount = totalCount
      };
    }

    public void CreateOrUpdateAccommodation(AccommodationDTO model)
    {
      var photoUrls = model.Photos.Where(p => p.StartsWith("http")).ToList();
      if (photoUrls.Any())
      {
        model.Photos = model.Photos.Except(photoUrls).ToList();
        var fileNames = _assetsService.DownloadFilesAsync(photoUrls, AssetType.Accommodation);
        model.Photos.AddRange(fileNames);
      }

      if (model.Id != 0)
      {
        var accommodation = _accommodationRepository.GetAccommodationById(model.Id);
        accommodation = _mapper.Map(model, accommodation);
        _accommodationRepository.UpdateAccommodation(accommodation);
      }
      else
        _accommodationRepository.CreateAccommodation(_mapper.Map<Accommodation>(model));
    }

    public AccommodationDTO GetAccommodation(int id)
    {
      var accommodation = _accommodationRepository.GetAccommodationById(id);
      return _mapper.Map<AccommodationDTO>(accommodation);
    }
  }
}
