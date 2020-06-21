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

    public IQueryable<Waypoint> GetWaypoints()
    {
      return _repositoryContext.Waypoints.AsNoTracking();
    }

    public void UpdateWaypoint(Waypoint wp)
    {
      _repositoryContext.Waypoints.Update(wp);
      _repositoryContext.SaveChanges();
    }

    public void DeleteWaypoint(Waypoint wp)
    {
      _repositoryContext.Waypoints.Remove(wp);
      _repositoryContext.SaveChanges();
    }

    public void DeleteRange(IEnumerable<Waypoint> wps)
    {
      _repositoryContext.Waypoints.RemoveRange(wps);
      _repositoryContext.SaveChanges();
    }

    public void UpdateRange(IEnumerable<Waypoint> wps)
    {
      _repositoryContext.Waypoints.UpdateRange(wps);
      _repositoryContext.SaveChanges();
    }

    public void AddWaypoint(Waypoint wp)
    {
      _repositoryContext.Waypoints.Add(wp);
      _repositoryContext.SaveChanges();
    }

  }
}
