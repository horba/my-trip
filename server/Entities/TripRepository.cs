using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Entities
{
  public class TripRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public TripRepository(RepositoryContext repositoryContext)
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
