using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using AutoMapper;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public class ScheduledPlaceToEatService
  {
    private readonly UserService _userService;
    private readonly ScheduledPlaceToEatRepository _scheduledPlaceToEatRepository;
    private readonly AttachmentFileEatingRepository _attachmentFileEatingRepository;
    private readonly IMapper _mapper;

    public ScheduledPlaceToEatService(
      UserService userService,
      ScheduledPlaceToEatRepository scheduledPlaceToEatRepository,
      AttachmentFileEatingRepository attachmentFileEatingRepository,
      IMapper mapper)
    {
      _userService = userService;
      _scheduledPlaceToEatRepository = scheduledPlaceToEatRepository;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
      _mapper = mapper;
    }

    public int CreateNewEating(InputScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
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
            var eating = new ScheduledPlaceToEat
            {
              UserId = scheduledPlaceToEatDTO.UserId,
              DateTime = scheduledPlaceToEatDTO.DateTime,
              Lat = scheduledPlaceToEatDTO.Lat,
              Lng = scheduledPlaceToEatDTO.Lng,
              Link = scheduledPlaceToEatDTO.Link,
              Notes = scheduledPlaceToEatDTO.Notes,
              NamePlace = scheduledPlaceToEatDTO.NamePlace,
              GooglePlaceId = scheduledPlaceToEatDTO.GooglePlaceId
            };
            return _scheduledPlaceToEatRepository.CreateScheduledPlaceToEat(eating);
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
          result.Add(this.ConvertScheduledPlaceToEatToOutputScheduletPlaceToEatDTO(eating));
        }
        //foreach(var scheduledPlaceToEatDTO in result)
        //{
        //  var attachments = _mapper.Map<IEnumerable<AttachmentFileEatingDTO>>(_attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEatDTO.Id));
        //  foreach(var attachment in attachments)
        //  {
        //    scheduledPlaceToEatDTO.FileNames.Append(attachment.Path);
        //  }
        //}
        return result;
      }
      else
      {
        return null;
      }
    }

    public void UpdateEating(InputScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          return;
        }
        else
        {
          if(_scheduledPlaceToEatRepository.GetScheduledPlaceToEatById(scheduledPlaceToEatDTO.Id) == null)
          {
            throw new ArgumentException();
          }
          var eating = ConvertInputScheduledPlaceToEatDTOToScheduletPlaceToEat(scheduledPlaceToEatDTO);
          _scheduledPlaceToEatRepository.UptateScheduledPlaceToEat(eating);
          return;
        }
      }
      catch(Exception e)
      {
        Console.WriteLine(e);
        return;
      }
    }

    public void DeleteScheduledPlaceToEat(InputScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          return;
        }
        else
        {
          var attachments = _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEatDTO.Id);
          foreach(var file in attachments)
          {
            File.Delete(file.Path);
            _attachmentFileEatingRepository.DeleteAttachmentFileEating(file);
          }
          _scheduledPlaceToEatRepository.DeleteScheduledPlaceToEat(new ScheduledPlaceToEat
          {
            Id = scheduledPlaceToEatDTO.Id,
            UserId = scheduledPlaceToEatDTO.UserId,
            DateTime = scheduledPlaceToEatDTO.DateTime,
            Lat = scheduledPlaceToEatDTO.Lat,
            Lng = scheduledPlaceToEatDTO.Lng,
            Link = scheduledPlaceToEatDTO.Link,
            Notes = scheduledPlaceToEatDTO.Notes,
            NamePlace = scheduledPlaceToEatDTO.NamePlace,
            GooglePlaceId = scheduledPlaceToEatDTO.GooglePlaceId
          });
        }
      }
      catch(Exception)
      {
        return;
      }
    }

    public void SaveFilesName(AttachmentFileEatingDTO attachmentFileEatingDTO)
    {
      //_attachmentFileEatingRepository.CreateAttachmentFileEating(new AttachmentFileEating { })
    }

    private bool Valid(InputScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
    {
      var results = new List<ValidationResult>();
      var context = new System.ComponentModel.DataAnnotations.ValidationContext(scheduledPlaceToEatDTO);
      try
      {
        if(!Validator.TryValidateObject(scheduledPlaceToEatDTO, context, results, true))
        {
          foreach(var error in results)
          {
            Console.WriteLine(error.ErrorMessage);
          }
          throw new ArgumentException();
        }
        else
        {
          return true;
        }
      }
      catch {
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
      if(scheduledPlaceToEat.Attachments != null)
      {
        var files = scheduledPlaceToEat.Attachments.Where(el => el.ScheduledPlaceToEatId.Equals(scheduledPlaceToEat.Id));
        foreach(var file in files)
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
        NamePlace = scheduledPlaceToEat.NamePlace,
        Notes = scheduledPlaceToEat.Notes
      };
    }
    public OutputScheduledPlaceToEatDTO ConvertInputScheduledPlaceToEatDTOToOutputScheduletPlaceToEatDTO(InputScheduledPlaceToEatDTO inputScheduledPlaceToEatDTO)
    {
      if(inputScheduledPlaceToEatDTO is null)
      {
        throw new ArgumentNullException(nameof(inputScheduledPlaceToEatDTO));
      }
      var files = _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(inputScheduledPlaceToEatDTO.Id);
      var fileNames = new List<string>();
      foreach(var file in files)
      {
        fileNames.Add(file.Path);
      }
      return new OutputScheduledPlaceToEatDTO
      {
        Id = inputScheduledPlaceToEatDTO.Id,
        DateTime = inputScheduledPlaceToEatDTO.DateTime,
        FileNames = fileNames,
        GooglePlaceId = inputScheduledPlaceToEatDTO.GooglePlaceId,
        Lat = inputScheduledPlaceToEatDTO.Lat,
        Lng = inputScheduledPlaceToEatDTO.Lng,
        Link = inputScheduledPlaceToEatDTO.Link,
        NamePlace = inputScheduledPlaceToEatDTO.NamePlace,
        Notes = inputScheduledPlaceToEatDTO.Notes
      };
    }

    public ScheduledPlaceToEat ConvertInputScheduledPlaceToEatDTOToScheduletPlaceToEat(InputScheduledPlaceToEatDTO inputScheduledPlaceToEatDTO)
    {
      if(inputScheduledPlaceToEatDTO is null)
      {
        throw new ArgumentNullException(nameof(inputScheduledPlaceToEatDTO));
      }
      return new ScheduledPlaceToEat
      {
        Id = inputScheduledPlaceToEatDTO.Id,
        DateTime = inputScheduledPlaceToEatDTO.DateTime,
        GooglePlaceId = inputScheduledPlaceToEatDTO.GooglePlaceId,
        Lat = inputScheduledPlaceToEatDTO.Lat,
        Lng = inputScheduledPlaceToEatDTO.Lng,
        Link = inputScheduledPlaceToEatDTO.Link,
        NamePlace = inputScheduledPlaceToEatDTO.NamePlace,
        Notes = inputScheduledPlaceToEatDTO.Notes
      };
    }
  }
}
