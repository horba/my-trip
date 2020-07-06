using System.Collections.Generic;
using System.Linq;
using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
  public interface IWaypointRepository
  {
    IQueryable<Waypoint> GetWaypoints();
    void UpdateWaypoint(Waypoint waypoint);
    void DeleteWaypoint(Waypoint waypoint);
    void DeleteRange(IEnumerable<Waypoint> waypoints);
    void UpdateRange(IEnumerable<Waypoint> waypoints);
    void AddWaypoint(Waypoint waypoint);
  }

  public class WaypointRepository : IWaypointRepository
  {
    private readonly IRepositoryContext _repositoryContext;

    public WaypointRepository(IRepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<Waypoint> GetWaypoints()
    {
      return _repositoryContext.Waypoints.AsNoTracking();
    }

    public void UpdateWaypoint(Waypoint waypoint)
    {
      _repositoryContext.Waypoints.Update(waypoint);
      _repositoryContext.SaveChanges();
    }

    public void DeleteWaypoint(Waypoint waypoint)
    {
      _repositoryContext.Waypoints.Remove(waypoint);
      _repositoryContext.SaveChanges();
    }

    public void DeleteRange(IEnumerable<Waypoint> waypoints)
    {
      _repositoryContext.Waypoints.RemoveRange(waypoints);
      _repositoryContext.SaveChanges();
    }

    public void UpdateRange(IEnumerable<Waypoint> waypoints)
    {
      _repositoryContext.Waypoints.UpdateRange(waypoints);
      _repositoryContext.SaveChanges();
    }

    public void AddWaypoint(Waypoint waypoint)
    {
      _repositoryContext.Waypoints.Add(waypoint);
      _repositoryContext.SaveChanges();
    }

  }
}
