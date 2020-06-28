using System.Collections.Generic;
using Entities.Models;
using WebAPI.DTO.ScheduledPlaceToEat;

namespace WebAPI.Interfaces
{
  public interface IScheduledPlaceToEatService
  {
    public int CreateNewEating(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO);

    public IEnumerable<OutputScheduledPlaceToEatDTO> GetEatingByUserId(int UserId);

    public bool UpdateScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateOrDeleteDTO scheduledPlaceToEatDTO);

    public bool DeleteScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateOrDeleteDTO scheduledPlaceToEatDTO);

    public OutputScheduledPlaceToEatDTO ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(ScheduledPlaceToEat scheduledPlaceToEat);

    public ScheduledPlaceToEat ConvertInputScheduledPlaceToEatForCreateDTOToScheduletPlaceToEat(InputScheduledPlaceToEatForCreateDTO inputScheduledPlaceToEatDTO);

    public ScheduledPlaceToEat ConvertInputScheduledPlaceToEatForUpdateOrDeleteDTOToScheduletPlaceToEat(InputScheduledPlaceToEatForUpdateOrDeleteDTO inputScheduledPlaceToEatDTO);
  }
}
