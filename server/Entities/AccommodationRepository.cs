﻿using Entities.Interfaces;
using Entities.Models;
using System.Linq;

namespace Entities
{
  public class AccommodationRepository
  {
    private readonly IRepositoryContext _repositoryContext;

    public AccommodationRepository(IRepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<Accommodation> GetUserAccommodations(int userId)
    {
      return _repositoryContext.Accommodations
        .Where(a => a.UserId.Equals(userId));
    }

    public Accommodation GetAccommodationById(int id)
    {
      return _repositoryContext.Accommodations
        .FirstOrDefault(a => a.Id.Equals(id));
    }

    public void CreateAccommodation(Accommodation accommodation)
    {
      _repositoryContext.Accommodations.Add(accommodation);
      _repositoryContext.SaveChanges();
    }

    public void UpdateAccommodation(Accommodation accommodation)
    {
      _repositoryContext.Accommodations.Update(accommodation);
      _repositoryContext.SaveChanges();
    }
  }
}
