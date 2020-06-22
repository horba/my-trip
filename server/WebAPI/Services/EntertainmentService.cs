using AutoMapper;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO;

namespace WebAPI.Services
{
  public class EntertainmentService
  {

    private readonly IMapper _mapper;
    private readonly EntertainmentRepository _entertainmentRepository;

    public EntertainmentService(IMapper mapper, EntertainmentRepository entertainmentRepository)
    {
      _mapper = mapper;
      _entertainmentRepository = entertainmentRepository;
    }

    public IEnumerable<EntertainmentDTO> GetEntertainments(int userId)
    {
      var entertainments = _entertainmentRepository.GetUserEntertainments(userId);
      return _mapper.Map<IEnumerable<EntertainmentDTO>>(entertainments.OrderBy(e => e.VisitDate).ToList());
    }

    public void CreateOrUpdateEntertainment(EntertainmentDTO model)
    {
      if (model.Id != 0)
      {
        var entertainment = _entertainmentRepository.GetEntertainmentById(model.Id);
        entertainment = _mapper.Map(model, entertainment);
        _entertainmentRepository.UpdateEntertainment(entertainment);
      }
      else
        _entertainmentRepository.CreateEntertainment(_mapper.Map<Entertainment>(model));
    }

    public EntertainmentDTO GetEntertainment(int id)
    {
      var entertainment = _entertainmentRepository.GetEntertainmentById(id);
      return _mapper.Map<EntertainmentDTO>(entertainment);
    }

  }
}
