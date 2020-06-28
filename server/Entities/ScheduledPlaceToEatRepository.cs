using System.Linq;
using Entities.Interfaces;
using Entities.Models;

namespace Entities
{
  public class ScheduledPlaceToEatRepository: IScheduledPlaceToEatRepository
  {
    private readonly IRepositoryContext RepositoryContext;

    public ScheduledPlaceToEatRepository(IRepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }

    public IQueryable<ScheduledPlaceToEat> GetScheduledPlaceToEatByUserId(int UserId)
    {
      return RepositoryContext.ScheduledPlacesToEat.Where(u => u.UserId.Equals(UserId));
    }

    public ScheduledPlaceToEat GetScheduledPlaceToEatById(int Id)
    {
      return RepositoryContext.ScheduledPlacesToEat.FirstOrDefault(u => u.Id.Equals(Id));
    }

    public int CreateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      RepositoryContext.ScheduledPlacesToEat.Add(scheduledPlaceToEat);
      RepositoryContext.SaveChanges();
      return scheduledPlaceToEat.Id;
    }

    public void UptateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      RepositoryContext.ScheduledPlacesToEat.Update(scheduledPlaceToEat);
      RepositoryContext.SaveChanges();
    }

    public void DeleteScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      RepositoryContext.ScheduledPlacesToEat.Remove(scheduledPlaceToEat);
      RepositoryContext.SaveChanges();
    }

    public void DeleteScheduledPlaceToEat(int id)
    {
      DeleteScheduledPlaceToEat(GetScheduledPlaceToEatById(id));
    }
  }
}
