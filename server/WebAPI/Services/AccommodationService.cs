using AutoMapper;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO;

namespace WebAPI.Services
{
  public class AccommodationService
  {
    private readonly IMapper _mapper;
    private readonly AccommodationRepository _accommodationRepository;

    public AccommodationService(IMapper mapper, AccommodationRepository accommodationRepository)
    {
      _mapper = mapper;
      _accommodationRepository = accommodationRepository;
    }

    public IEnumerable<AccommodationDTO> GetAccommodations(int userId)
    {
      var accommodations = _accommodationRepository.GetUserAccommodations(userId);
      return _mapper.Map<IEnumerable<AccommodationDTO>>(accommodations.OrderBy(t => t.DepartureDateTime).ToList());
    }

    public void CreateOrUpdateAccommodation(AccommodationDTO model)
    {
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
