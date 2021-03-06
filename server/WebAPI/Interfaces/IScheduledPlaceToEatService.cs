﻿using System.Collections.Generic;
using Entities.Models;
using WebAPI.DTO;
using WebAPI.DTO.ScheduledPlaceToEat;

namespace WebAPI.Interfaces
{
  public interface IScheduledPlaceToEatService
  {
    public int CreateNewEating(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO);

    public IPagedResponse<OutputScheduledPlaceToEatDTO> GetEatingByUserId(int UserId, int page, int pageSize);

    public OutputScheduledPlaceToEatDTO GetEatingById(int id);

    public bool UpdateScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO);

    public bool DeleteScheduledPlaceToEat(int eatingId, int userId);

    public OutputScheduledPlaceToEatDTO AddFileNames(ScheduledPlaceToEat scheduledPlaceToEat);
  }
}
