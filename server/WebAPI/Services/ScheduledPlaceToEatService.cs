using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Entities.Interfaces;
using Entities.Models;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Interfaces;

namespace WebAPI.Services
{
  public class ScheduledPlaceToEatService : IScheduledPlaceToEatService
  {
    private readonly UserService _userService;
    private readonly IScheduledPlaceToEatRepository _scheduledPlaceToEatRepository;
    private readonly IAttachmentFileEatingRepository _attachmentFileEatingRepository;

    public ScheduledPlaceToEatService(
      UserService userService,
      IScheduledPlaceToEatRepository scheduledPlaceToEatRepository,
      IAttachmentFileEatingRepository attachmentFileEatingRepository)
    {
      _userService = userService;
      _scheduledPlaceToEatRepository = scheduledPlaceToEatRepository;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
    }

    public int CreateNewEating(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          throw new ArgumentException();
        }
        else
        {
          if(_userService.GetUser(scheduledPlaceToEatDTO.UserId) != null)
          {
            return _scheduledPlaceToEatRepository.CreateScheduledPlaceToEat(ConvertInputScheduledPlaceToEatForCreateDTOToScheduletPlaceToEat(scheduledPlaceToEatDTO));
          }
          else
          {
            throw new ArgumentException();
          }
        }
      }
      catch(Exception)
      {
        return -1;
      }
    }

    public IEnumerable<OutputScheduledPlaceToEatDTO> GetEatingByUserId(int UserId)
    {
      if(_userService.GetUser(UserId) != null)
      {
        var eatings = _scheduledPlaceToEatRepository.GetScheduledPlaceToEatByUserId(UserId);
        List<OutputScheduledPlaceToEatDTO> result = new List<OutputScheduledPlaceToEatDTO>();
        foreach(var eating in eatings)
        {
          result.Add(ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(eating));
        }
        return result;
      }
      else
      {
        return null;
      }
    }

    public OutputScheduledPlaceToEatDTO GetEatingById(int id)
    {
      return ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(_scheduledPlaceToEatRepository.GetScheduledPlaceToEatById(id));
    }

    public bool UpdateScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          throw new ArgumentException();
        }
        else
        {
          var oldEating = _scheduledPlaceToEatRepository.GetScheduledPlaceToEatById(scheduledPlaceToEatDTO.Id);
          if( oldEating == null)
          {
            throw new ArgumentException();
          }
          oldEating.Notes = scheduledPlaceToEatDTO.Notes;
          oldEating.NamePlace = scheduledPlaceToEatDTO.PlaceName;
          oldEating.Lng = scheduledPlaceToEatDTO.Lng;
          oldEating.Lat = scheduledPlaceToEatDTO.Lat;
          oldEating.Link = scheduledPlaceToEatDTO.Link;
          oldEating.GooglePlaceId = scheduledPlaceToEatDTO.GooglePlaceId;
          oldEating.DateTime = scheduledPlaceToEatDTO.DateTime;
          _scheduledPlaceToEatRepository.UptateScheduledPlaceToEat(oldEating);
          return true;
        }
      }
      catch(Exception)
      {
        return false;
      }
    }

    public bool DeleteScheduledPlaceToEat(int eatingId, int userId)
    {
      try
      {
        _scheduledPlaceToEatRepository.DeleteScheduledPlaceToEat(eatingId);
        return true;
      }
      catch(Exception)
      {
        return false;
      }
    }

    public OutputScheduledPlaceToEatDTO ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      if(scheduledPlaceToEat is null)
      {
        throw new ArgumentNullException(nameof(scheduledPlaceToEat));
      }
      var fileNames = new List<string>();
      var attachmentFileEatings = _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEat.Id);
      if(attachmentFileEatings != null)
      {
        foreach(var file in attachmentFileEatings)
        {
          fileNames.Add(file.Path);
        }
      }
      return new OutputScheduledPlaceToEatDTO
      {
        Id = scheduledPlaceToEat.Id,
        DateTime = scheduledPlaceToEat.DateTime,
        FileNames = fileNames,
        GooglePlaceId = scheduledPlaceToEat.GooglePlaceId,
        Lat = scheduledPlaceToEat.Lat,
        Lng = scheduledPlaceToEat.Lng,
        Link = scheduledPlaceToEat.Link,
        PlaceName = scheduledPlaceToEat.NamePlace,
        Notes = scheduledPlaceToEat.Notes
      };
    }

    public ScheduledPlaceToEat ConvertInputScheduledPlaceToEatForCreateDTOToScheduletPlaceToEat(InputScheduledPlaceToEatForCreateDTO inputScheduledPlaceToEatDTO)
    {
      if(inputScheduledPlaceToEatDTO is null)
      {
        throw new ArgumentNullException(nameof(inputScheduledPlaceToEatDTO));
      }
      return new ScheduledPlaceToEat
      {
        DateTime = inputScheduledPlaceToEatDTO.DateTime,
        GooglePlaceId = inputScheduledPlaceToEatDTO.GooglePlaceId,
        Lat = inputScheduledPlaceToEatDTO.Lat,
        Lng = inputScheduledPlaceToEatDTO.Lng,
        Link = inputScheduledPlaceToEatDTO.Link,
        NamePlace = inputScheduledPlaceToEatDTO.PlaceName,
        Notes = inputScheduledPlaceToEatDTO.Notes,
        UserId = inputScheduledPlaceToEatDTO.UserId
      };
    }

    private bool Valid(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO)
    {
      var results = new List<ValidationResult>();
      var context = new ValidationContext(scheduledPlaceToEatDTO);
      try
      {
        if(!Validator.TryValidateObject(scheduledPlaceToEatDTO, context, results, true))
        {
          throw new ArgumentException();
        }
        else
        {
          return true;
        }
      }
      catch
      {
        return false;
      }
    }

    private bool Valid(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO)
    {
      var results = new List<ValidationResult>();
      var context = new ValidationContext(scheduledPlaceToEatDTO);
      try
      {
        if(!Validator.TryValidateObject(scheduledPlaceToEatDTO, context, results, true))
        {
          throw new ArgumentException();
        }
        else
        {
          return true;
        }
      }
      catch
      {
        return false;
      }
    }
  }
}
