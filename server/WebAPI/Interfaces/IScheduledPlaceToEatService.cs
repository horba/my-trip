using System.Collections.Generic;
using Entities.Models;
using WebAPI.DTO.ScheduledPlaceToEat;

namespace WebAPI.Interfaces
{
  public interface IScheduledPlaceToEatService
  {
    public int CreateNewEating(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO);

    public IEnumerable<OutputScheduledPlaceToEatDTO> GetEatingByUserId(int UserId);

    public OutputScheduledPlaceToEatDTO GetEatingById(int id);

    public bool UpdateScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO);

    public bool DeleteScheduledPlaceToEat(int eatingId, int userId);

    public OutputScheduledPlaceToEatDTO ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(ScheduledPlaceToEat scheduledPlaceToEat);

    public ScheduledPlaceToEat ConvertInputScheduledPlaceToEatForCreateDTOToScheduletPlaceToEat(InputScheduledPlaceToEatForCreateDTO inputScheduledPlaceToEatDTO);
  }
}
