using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.DTO;
using WebAPI.Mappers;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        private readonly TicketsService _ticketsService;
        private readonly UserService _userService;

        private readonly IMapper _mapper;

        public TicketsController(TicketsService ticketsService, UserService userService)
        {
            _ticketsService = ticketsService;
            _userService = userService;
            _mapper = new MapperConfiguration(
                    mc => { mc.AddProfile(new TicketsMappingProfile()); }
            ).CreateMapper();
        }

        [Authorize]
        [HttpGet("")]
        public IActionResult GetTickets()
        {
            var userId = HttpContext.User.Identity.Name;
            if (userId == null) return Unauthorized();
            var user = _userService.GetUser(int.Parse(userId));
            var tickets = _ticketsService.GetTickets(user);
            var ticketDtos = _mapper.Map<List<TicketDto>>(tickets);
            return Ok(ticketDtos);
        }
    }
}
