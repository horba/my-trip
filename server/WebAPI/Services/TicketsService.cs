using System.Collections.Generic;
using AutoMapper;
using Entities;
using Entities.Models;
using WebAPI.DTO.UserSettings;
using WebAPI.Mappers;

namespace WebAPI.Services
{
  public class TicketsService
  {

    private readonly TicketsRepository _ticketsRepository;

    public TicketsService(TicketsRepository ticketsRepository)
    {
      _ticketsRepository = ticketsRepository;
    }

    public List<Ticket> GetTickets(User user) {
        var tickets = _ticketsRepository.GetTickets(user);
        return tickets;
    }

  }
}
