using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Services.Assets;

namespace WebAPI.Services
{
  public class AttachmentFileEatingService
  {
    private readonly AssetsService _assetsService;
    private readonly AttachmentFileEatingRepository _attachmentFileEatingRepository;
    private readonly ScheduledPlaceToEatService _scheduledPlaceToEatService;
    private readonly UserService _userService;

    public AttachmentFileEatingService(AssetsService assetsService, AttachmentFileEatingRepository attachmentFileEatingRepository, ScheduledPlaceToEatService scheduledPlaceToEatService, UserService userService)
    {
      _assetsService = assetsService;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
      _scheduledPlaceToEatService = scheduledPlaceToEatService;
      _userService = userService;
    }

    public async void Create(IFormFile file, int eatingId, int userId)
    {
      if(_userService.GetUser(userId) != null && _scheduledPlaceToEatService.GetEatingByUserId(userId).Where(el => el.Id.Equals(eatingId)).First() != null)
      {
        if(file.Length >= Consts.MaxEatingFileSize)
        {
          return;
        }
        var fileName = await _assetsService.SaveFileAsync(file, AssetType.FileEating);
        _attachmentFileEatingRepository.CreateAttachmentFileEating(new Entities.Models.AttachmentFileEating { Path = fileName, ScheduledPlaceToEatId = eatingId });
      }
    }

    public void DeleteFilesEating(int eatingId, int userId)
    {
      if(_userService.GetUser(userId) != null && _scheduledPlaceToEatService.GetEatingByUserId(userId).Where(el => el.Id.Equals(eatingId)).First() != null)
      {
        foreach(var file in _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(eatingId))
        {
          _assetsService.DeleteFile(file.Path, AssetType.FileEating);
          _attachmentFileEatingRepository.DeleteAttachmentFileEating(file);
        }
      }
    }

    public void Delete(int fileId, int userId)
    {
      var attachmentFileEating = _attachmentFileEatingRepository.GetAttachmentFileEatingById(fileId);
      if(_userService.GetUser(userId) != null && attachmentFileEating != null && attachmentFileEating.ScheduledPlaceToEat.UserId == userId)
      {
        _assetsService.DeleteFile(attachmentFileEating.Path, AssetType.FileEating);
        _attachmentFileEatingRepository.DeleteAttachmentFileEating(attachmentFileEating);
      }
    }
  }
}
