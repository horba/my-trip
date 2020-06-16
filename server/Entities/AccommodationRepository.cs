using Entities.Models;
using System;
using System.Linq;

namespace Entities
{
  public class AccommodationRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public AccommodationRepository(RepositoryContext repositoryContext)
    {
      this.RepositoryContext = repositoryContext;
    }

    public IQueryable<Accommodation> GetUserAccommodations(int userId)
    {
      return RepositoryContext.Accommodations
        .Where(a => a.UserId.Equals(userId));
    }

    public Accommodation GetAccommodationById(int id)
    {
      return RepositoryContext.Accommodations
        .FirstOrDefault(a => a.Id.Equals(id));
    }

    public void CreateAccommodation(Accommodation accommodation)
    {
      RepositoryContext.Accommodations.Add(accommodation);
      RepositoryContext.SaveChanges();
    }

    public void UpdateAccommodation(Accommodation accommodation)
    {
      RepositoryContext.Accommodations.Update(accommodation);
      RepositoryContext.SaveChanges();
    }
  }
}
