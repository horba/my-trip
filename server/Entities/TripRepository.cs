using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Entities
{
  public interface ITripRepository
  {
    IQueryable<Trip> GetUserTrips(int userId);
    void CreateTrip(Trip trip);
  }

  public class TripRepository : ITripRepository
  {
    private readonly IRepositoryContext RepositoryContext;

    public TripRepository(IRepositoryContext repositoryContext)
    {
      this.RepositoryContext = repositoryContext;
    }

    public IQueryable<Trip> GetUserTrips(int userId)
    {
      return RepositoryContext.Trips
        .Include(i => i.DepartureCountry)
        .Include(i => i.ArrivalCountry)
        .Where(u => u.UserId.Equals(userId));
    }

    public void CreateTrip(Trip trip)
    {
      RepositoryContext.Trips.Add(trip);
      RepositoryContext.SaveChanges();
    }

  }
}
