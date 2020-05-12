using Entities.Models;
using System;
using System.Collections.Generic;

namespace WebAPI.DTO
{
    public class TicketDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Price { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public List<RouteDto> Routes { get; set; }
    }
}
