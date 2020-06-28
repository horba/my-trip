using System.Linq;
using Entities.Models;

namespace Entities.Interfaces
{
  public interface IScheduledPlaceToEatRepository
  {
    public IQueryable<ScheduledPlaceToEat> GetScheduledPlaceToEatByUserId(int UserId);

    public ScheduledPlaceToEat GetScheduledPlaceToEatById(int Id);

    public int CreateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat);

    public void UptateScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat);

    public void DeleteScheduledPlaceToEat(ScheduledPlaceToEat scheduledPlaceToEat);

    public void DeleteScheduledPlaceToEat(int id);
  }
}
