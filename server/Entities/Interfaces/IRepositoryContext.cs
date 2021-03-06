﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities.Interfaces
{

  public interface IRepositoryContext
  {
    DbSet<User> Users { get; set; }

    DbSet<Ticket> Tickets { get; set; }

    DbSet<TicketRoute> TicketRoutes { get; set; }

    DbSet<Country> Countries { get; set; }

    DbSet<Language> Languages { get; set; }

    DbSet<Trip> Trips { get; set; }

    DbSet<ScheduledPlaceToEat> ScheduledPlacesToEat { get; set; }

    DbSet<AttachmentFileEating> AttachmentFilesEating { get; set; }

    DbSet<Waypoint> Waypoints { get; set; }

    DbSet<WaypointFile> WaypointFiles { get; set; }

    DbSet<Entertainment> Entertainments { get; set; }

    DbSet<Accommodation> Accommodations { get; set; }

    int SaveChanges();
  }
}
