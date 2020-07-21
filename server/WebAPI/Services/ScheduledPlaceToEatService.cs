using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AutoMapper;
using Entities.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using WebAPI.DTO;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Interfaces;
using WebAPI.Mappers;

namespace WebAPI.Services
{
  public class ScheduledPlaceToEatService : IScheduledPlaceToEatService
  {
    private readonly UserService _userService;
    private readonly IScheduledPlaceToEatRepository _scheduledPlaceToEatRepository;
    private readonly IAttachmentFileEatingRepository _attachmentFileEatingRepository;
    private readonly IMapper _mapper;

    public ScheduledPlaceToEatService(
      UserService userService,
      IScheduledPlaceToEatRepository scheduledPlaceToEatRepository,
      IAttachmentFileEatingRepository attachmentFileEatingRepository)
    {
      _userService = userService;
      _scheduledPlaceToEatRepository = scheduledPlaceToEatRepository;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
      _mapper = new MapperConfiguration(
                    mc => { mc.AddProfile(new SheduledPlaceToEatMappingProfile()); }
            ).CreateMapper();
    }

    public int CreateNewEating(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!IsValid(scheduledPlaceToEatDTO))
        {
          throw new ArgumentException();
        }
        else
        {
          if(_userService.GetUser(scheduledPlaceToEatDTO.UserId) != null)
          {
            return _scheduledPlaceToEatRepository.CreateScheduledPlaceToEat(_mapper.Map<ScheduledPlaceToEat>(scheduledPlaceToEatDTO));
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

    public IPagedResponse<OutputScheduledPlaceToEatDTO> GetEatingByUserId(int UserId, int page, int pageSize)
    {
      if(_userService.GetUser(UserId) != null)
      {
        var eatings = _scheduledPlaceToEatRepository.GetScheduledPlaceToEatByUserId(UserId);
        var TotalCount = eatings.Count();
        eatings = eatings.Skip(page * pageSize).Take(pageSize);
        List<OutputScheduledPlaceToEatDTO> result = new List<OutputScheduledPlaceToEatDTO>();
        foreach(var eating in eatings)
        {
          result.Add(AddFileNames(eating));
        }
        return new IPagedResponse<OutputScheduledPlaceToEatDTO>()
        {
          Data = result,
          PageNumber = page,
          PageSize = pageSize,
          PageCount = (int?)Math.Ceiling((double)TotalCount / pageSize),
          TotalCount = TotalCount
        };
      }
      else
      {
        return null;
      }
    }

    public OutputScheduledPlaceToEatDTO GetEatingById(int id)
    {
      return AddFileNames(_scheduledPlaceToEatRepository.GetScheduledPlaceToEatById(id));
    }

    public bool UpdateScheduledPlaceToEat(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!IsValid(scheduledPlaceToEatDTO))
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

    public OutputScheduledPlaceToEatDTO AddFileNames(ScheduledPlaceToEat scheduledPlaceToEat)
    {
      if(scheduledPlaceToEat == null)
      {
        throw new ArgumentNullException("sheduledPlaceToEat");
      }
      var fileNames = new List<string>();
      var attachmentFileEatings = _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEat.Id).AsNoTracking();
      if(attachmentFileEatings != null)
      {
        foreach(var file in attachmentFileEatings)
        {
          fileNames.Add(file.Path);
        }
      }
      var outputScheduledPlaceToEatDTO = _mapper.Map<OutputScheduledPlaceToEatDTO>(scheduledPlaceToEat);
      outputScheduledPlaceToEatDTO.FileNames = fileNames;
      return outputScheduledPlaceToEatDTO;
    }

    private bool IsValid(InputScheduledPlaceToEatForUpdateDTO scheduledPlaceToEatDTO)
    {
      var results = new List<ValidationResult>();
      var context = new System.ComponentModel.DataAnnotations.ValidationContext(scheduledPlaceToEatDTO);
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

    private bool IsValid(InputScheduledPlaceToEatForCreateDTO scheduledPlaceToEatDTO)
    {
      var results = new List<ValidationResult>();
      var context = new System.ComponentModel.DataAnnotations.ValidationContext(scheduledPlaceToEatDTO);
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
