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
    private readonly AssetsService _filesService;
    private IWebHostEnvironment _webHostEnvironment;

    public ScheduledPlaceToEatService(
      UserService userService,
      ScheduledPlaceToEatRepository scheduledPlaceToEatRepository,
      AttachmentFileEatingRepository attachmentFileEatingRepository,
      IMapper mapper,
      IWebHostEnvironment webHostEnvironment,
      AssetsService filesService)
    {
      _userService = userService;
      _scheduledPlaceToEatRepository = scheduledPlaceToEatRepository;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
      _mapper = mapper;
      _webHostEnvironment = webHostEnvironment;
      _filesService = filesService;
    }

    public void CreateNewEating(ScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          return;
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
            _scheduledPlaceToEatRepository.CreateScheduledPlaceToEat(eating);
            if(scheduledPlaceToEatDTO.Attachments != null)
            {
              foreach(var file in scheduledPlaceToEatDTO.Attachments)
              {
                var fileName = Path.GetRandomFileName();
                var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, Consts.FileEatingPath, fileName);
                File.Create(filePath);
                _attachmentFileEatingRepository.CreateAttachmentFileEating(new AttachmentFileEating
                {
                  ScheduledPlaceToEatId = eating.Id,
                  Path = fileName
                });
              }
            }
          }
          else
          {
            throw new ArgumentException();
          }
        }
      }
      catch(Exception)
      {
        return;
      }
    }

    public IEnumerable<ScheduledPlaceToEatDTO> GetEatingByUserId(int UserId)
    {
      if(_userService.GetUser(UserId) != null)
      {
        var eating =_scheduledPlaceToEatRepository.GetScheduledPlaceToEatByUserId(UserId).ToList();
        var mappedEating = _mapper.Map<IEnumerable<ScheduledPlaceToEatDTO>>(eating.OrderBy(t => t.Id).ToList());
        foreach(var scheduledPlaceToEatDTO in mappedEating)
        {
          var attachments = _mapper.Map<IEnumerable<AttachmentFileEatingDTO>>(_attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEatDTO.Id));
          foreach(var attachment in attachments)
          {
            scheduledPlaceToEatDTO.FileNames.Append(attachment.FileName);
          }
        }
        return mappedEating;
      }
      else
      {
        return null;
      }
    }

    public void UpdateEating(ScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
    {
      try
      {
        if(!Valid(scheduledPlaceToEatDTO))
        {
          return;
        }
        else
        {
          if(_scheduledPlaceToEatRepository.GetScheduledPlaceToEatById(scheduledPlaceToEatDTO.Id) != null)
          {
            throw new ArgumentException();
          }
          var oldfiles = _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(scheduledPlaceToEatDTO.Id);
          foreach(var file in oldfiles)
          {
            File.Delete(file.Path);
            _attachmentFileEatingRepository.DeleteAttachmentFileEating(file);
          }
          if(scheduledPlaceToEatDTO.Attachments != null)
          {
            foreach(var file in scheduledPlaceToEatDTO.Attachments)
            {
              var fileName = Path.Combine(_webHostEnvironment.ContentRootPath, Consts.FileEatingPath, Path.GetRandomFileName());
              File.Create(fileName);
              _attachmentFileEatingRepository.CreateAttachmentFileEating(new AttachmentFileEating
              {
                ScheduledPlaceToEatId = scheduledPlaceToEatDTO.Id,
                Path = fileName
              });
            }
          }
          var eating = new ScheduledPlaceToEat
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
          };
          _scheduledPlaceToEatRepository.UptateScheduledPlaceToEat(eating);
          return;
        }
      }
      catch(Exception)
      {
        return;
      }
    }

    public void DeleteScheduledPlaceToEat(ScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
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

    private bool Valid(ScheduledPlaceToEatDTO scheduledPlaceToEatDTO)
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
  }
}
