using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Entities.Models;

namespace Entities
{
  public class ScheduledPlaceToEatRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public ScheduledPlaceToEatRepository(RepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }
    public IQueryable<ScheduledPlaceToEat> GetScheduledPlaceToEatByUserId(int UserId)
    {
      return RepositoryContext.ScheduledPlacesToEat.Where(u => u.UserId.Equals(UserId));
    }
    public ScheduledPlaceToEat GetScheduledPlaceToEatById(int Id)
    {
      return RepositoryContext.ScheduledPlacesToEat.Where(u => u.Id.Equals(Id)).FirstOrDefault();
    }

    public int CreateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      RepositoryContext.ScheduledPlacesToEat.Add(scheduledPlaceToEat);
      RepositoryContext.SaveChanges();
      return scheduledPlaceToEat.Id;
    }

    public void UptateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      /*if(RepositoryContext.ScheduledPlacesToEat.Where(u => u.UserId.Equals(scheduledPlaceToEat.UserId) && u.Id.Equals(scheduledPlaceToEat.Id)) != null)
      {*/
        RepositoryContext.ScheduledPlacesToEat.Update(scheduledPlaceToEat);
        RepositoryContext.SaveChanges();
      /*}*/
    }

    public void DeleteScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      if(RepositoryContext.ScheduledPlacesToEat.Where(u => u.UserId.Equals(scheduledPlaceToEat.UserId) && u.Id.Equals(scheduledPlaceToEat.Id)) != null)
      {
        RepositoryContext.ScheduledPlacesToEat.Remove(scheduledPlaceToEat);
        RepositoryContext.SaveChanges();
      }
    }
  }
}
