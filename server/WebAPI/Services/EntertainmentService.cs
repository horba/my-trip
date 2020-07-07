using AutoMapper;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO;

namespace WebAPI.Services
{
  public interface IEntertainmentService
  {
    PagedResponse<EntertainmentDTO> GetEntertainments(int userId, PaginationRequestDTO paginationRequest);
    void CreateOrUpdateEntertainment(EntertainmentDTO model);
    EntertainmentDTO GetEntertainment(int id);
    void RemoveFilePath(int id);
  }

  public class EntertainmentService: IEntertainmentService
  {

    private readonly IMapper _mapper;
    private readonly IEntertainmentRepository _entertainmentRepository;

    public EntertainmentService(IMapper mapper, IEntertainmentRepository entertainmentRepository)
    {
      _mapper = mapper;
      _entertainmentRepository = entertainmentRepository;
    }

    private IQueryable<Entertainment> PaginateEntertainments(IQueryable<Entertainment> entertainments, PaginationRequestDTO paginationRequest)
    {
      return entertainments
        .Skip((int)(paginationRequest.PageNumber * paginationRequest.PageSize))
        .Take((int)paginationRequest.PageSize);
    }

    public PagedResponse<EntertainmentDTO> GetEntertainments(int userId, PaginationRequestDTO paginationRequest)
    {
      var entertainments = _entertainmentRepository.GetUserEntertainments(userId);
      int totalCount = (int)Math.Ceiling(entertainments.Count() / (double)paginationRequest.PageSize);
      entertainments = PaginateEntertainments(entertainments, paginationRequest);
      return new PagedResponse<EntertainmentDTO>
      {
        Data = _mapper.Map<IEnumerable<EntertainmentDTO>>(entertainments.ToList()),
        PageSize = paginationRequest.PageSize,
        PageNumber = paginationRequest.PageNumber,
        TotalCount = totalCount
      };
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
    
    public void RemoveFilePath(int id) {
      var entertainment = _entertainmentRepository.GetEntertainmentById(id);
      entertainment.EntertainmentFilePath = null;
      _entertainmentRepository.UpdateEntertainment(entertainment);
    }

  }
}
