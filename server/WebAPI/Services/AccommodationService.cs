using System;
using AutoMapper;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.Configuration.Conventions;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore.Internal;
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

      return accommodationSortingQuery.SortBy switch
      {
        AccommodationSortBy.ByReservationDate => orderFunc(accommodation => accommodation.ArrivalDateTime),
        AccommodationSortBy.ByCostPerNight => orderFunc(accommodation => accommodation.Price),
        _ => orderFunc(accommodation => accommodation.Name)
      };
    }

    private IQueryable<Accommodation> FilterAccommodations(IQueryable<Accommodation> accommodations, AccommodationFilterQueryDTO accommodationFilterQuery)
    {
      if (accommodationFilterQuery.MinPrice.HasValue)
      {
        accommodations =
          accommodations.Where(accommodation => accommodation.Price >= accommodationFilterQuery.MinPrice);
      }

      if (accommodationFilterQuery.MaxPrice.HasValue)
      {
        accommodations =
          accommodations.Where(accommodation => accommodation.Price <= accommodationFilterQuery.MaxPrice);
      }

      if (accommodationFilterQuery.Year.HasValue)
      {
        accommodations = accommodations.Where(accommodation =>
          accommodation.ArrivalDateTime.Year == accommodationFilterQuery.Year);
      }

      try
      {
        var countries = Array.ConvertAll(accommodationFilterQuery.Countries.Split(';', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        accommodations = accommodations.Where(accommodation => countries.Any(id => id == accommodation.CountryId));
      }
      catch
      {
        // ignored
      }

      return accommodations;
    }

    public PagedResponse<AccommodationDTO> GetAccommodations(
      int userId,
      PaginationRequestQueryDTO paginationRequestQuery,
      AccommodationSortingQueryDTO accommodationSortingQuery,
      AccommodationFilterQueryDTO accommodationFilterQuery)
    {
      var accommodations = _accommodationRepository.GetUserAccommodations(userId);
      accommodations = FilterAccommodations(accommodations, accommodationFilterQuery);
      int totalCount = accommodations.Count();
      accommodations = SortAccommodations(accommodations, accommodationSortingQuery);
      accommodations = PaginateAccommodations(accommodations, paginationRequestQuery);

      return new PagedResponse<AccommodationDTO>
      {
        Data = _mapper.Map<IEnumerable<AccommodationDTO>>(accommodations.ToList()),
        PageSize = paginationRequestQuery.PageSize,
        PageNumber = paginationRequestQuery.PageNumber,
        TotalCount = totalCount,
        PageCount = (int)Math.Ceiling(totalCount / ((double?)paginationRequestQuery.PageSize ?? 10))
      };
    }

    public int GetMaxPrice(int userId)
    {
      return (int)Math.Ceiling(_accommodationRepository.GetUserAccommodations(userId).Max(field => field.Price));
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
