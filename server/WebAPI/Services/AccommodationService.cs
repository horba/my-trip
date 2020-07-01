using AutoMapper;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO;
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

    public IEnumerable<AccommodationDTO> GetAccommodations(int userId)
    {
      var accommodations = _accommodationRepository.GetUserAccommodations(userId);
      return _mapper.Map<IEnumerable<AccommodationDTO>>(accommodations.OrderBy(t => t.DepartureDateTime).ToList());
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
