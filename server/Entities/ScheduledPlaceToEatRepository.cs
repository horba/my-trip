using System.Linq;
using Entities.Interfaces;
using Entities.Models;

namespace Entities
{
  public class ScheduledPlaceToEatRepository : IScheduledPlaceToEatRepository
  {
    private readonly IRepositoryContext _repositoryContext;

    public ScheduledPlaceToEatRepository(IRepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<ScheduledPlaceToEat> GetScheduledPlaceToEatByUserId(int UserId)
    {
      return _repositoryContext.ScheduledPlacesToEat.Where(u => u.UserId.Equals(UserId));
    }

    public ScheduledPlaceToEat GetScheduledPlaceToEatById(int Id)
    {
      return _repositoryContext.ScheduledPlacesToEat.FirstOrDefault(u => u.Id.Equals(Id));
    }

    public int CreateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      _repositoryContext.ScheduledPlacesToEat.Add(scheduledPlaceToEat);
      _repositoryContext.SaveChanges();
      return scheduledPlaceToEat.Id;
    }

    public void UptateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      _repositoryContext.ScheduledPlacesToEat.Update(scheduledPlaceToEat);
      _repositoryContext.SaveChanges();
    }

    public void DeleteScheduledPlaceToEat(int id)
    {
      var scheduledPlaceToEat = GetScheduledPlaceToEatById(id);
      _repositoryContext.ScheduledPlacesToEat.Remove(scheduledPlaceToEat);
      _repositoryContext.SaveChanges();
    }
  }
}
