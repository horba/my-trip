using System;
using System.Linq;
using AutoMapper;
using Entities.Models;
using WebAPI.DTO;

namespace WebAPI.Mappers
{
    public class TicketsMappingProfile : Profile
    {
        public TicketsMappingProfile()
        {
            CreateMap<Ticket, TicketDto>()
                .ForMember(dto => dto.Price,
                    opt => opt.MapFrom(
                        ticket => ticket.Routes.Sum(route => route.Price) + " $"
                    ));

            CreateMap<TicketRoute, RouteDto>()
                .ForMember(dto => dto.Date, opt => opt.MapFrom(
                    route => route.DepartureDateTime.ToString("d MMM, ddd")))
                .ForMember(dto => dto.DepartureTime, opt => opt.MapFrom(
                    route => route.DepartureDateTime.ToString("HH:mm")))
                .ForMember(dto => dto.ArrivalTime, opt => opt.MapFrom(
                    route => route.ArrivalDateTime.ToString("HH:mm")))
                .ForMember(dto => dto.Hours, opt => opt.MapFrom(
                    route => Convert.ToInt32((route.ArrivalDateTime - route.DepartureDateTime).TotalHours)))
                .ForMember(dto => dto.Minutes, opt => opt.MapFrom(
                route => Convert.ToInt32((route.ArrivalDateTime - route.DepartureDateTime).TotalMinutes % 60))
                );
        }
    }
}
