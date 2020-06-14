using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Entities
{
  public class WaypointRepository
  {
    private readonly RepositoryContext _repositoryContext;

    public WaypointRepository(RepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<Waypoint> GetWaypointsByTripId(int tripId)
    {
      return _repositoryContext.Waypoints
        .AsNoTracking()
        .Where(w => w.TripId == tripId)
        .OrderBy(w => w.Order);
    }

    public Waypoint GetWaypoint(int id)
    {
      return _repositoryContext.Waypoints
        .AsNoTracking()
        .FirstOrDefault(wp => wp.Id == id);
    }

    public int? GetWaypointUserOwner(int id)
    {
      return _repositoryContext.Waypoints
        .AsNoTracking()
        .Where(wp => wp.Id == id)
        .Include(wp => wp.Trip)
        .FirstOrDefault()
        ?.Trip
        ?.UserId;
    }

    public void UpdateWaypoint(Waypoint wp)
    {
      _repositoryContext.Update(wp);
      _repositoryContext.SaveChanges();
    }

    public void DeleteWaypoint(Waypoint wp)
    {
      _repositoryContext.Remove(wp);
      _repositoryContext.SaveChanges();
    }

    //public KeyValuePair<int, int> AddWaypoint(Waypoint waypoint, string departureCity)
    //{
    //  int tripId = waypoint.TripId;
    //  int newOrder = _repositoryContext.Waypoints
    //                   .FirstOrDefault(w => w.TripId == tripId && w.City.Equals(departureCity, StringComparison.CurrentCultureIgnoreCase))?.Id + 1 ??
    //                 _repositoryContext.Waypoints.Count(w => w.TripId == tripId);

    //  _repositoryContext.Waypoints.Where(w => w.TripId == tripId && w.Order >= newOrder)
    //    .ToList()
    //    .ForEach(w => w.Order++);
    //  waypoint.Order = newOrder;
    //  _repositoryContext.Add(waypoint);
    //  _repositoryContext.SaveChanges();

    //  return new KeyValuePair<int, int>(waypoint.Id, newOrder);
    //}

    //public void DeleteWaypoint(int id)
    //{
    //  var wp = _repositoryContext.Waypoints.FirstOrDefault(w => w.Id == id);

    //  _repositoryContext.Waypoints.Where(w => w.TripId == wp.TripId && w.Order > wp.Order)
    //    .ToList()
    //    .ForEach(w => w.Order--);

    //  _repositoryContext.Waypoints.Remove(wp);
    //  _repositoryContext.SaveChanges();
    //}
  }
}
