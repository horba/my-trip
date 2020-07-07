using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using WebAPI.DTO.ScheduledPlaceToEat;
using WebAPI.Interfaces;
using WebAPI.Services.Assets;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebAPI.Services
{
  public class AttachmentFileEatingService: IAttachmentFileEatingService
  {
    private readonly AssetsService _assetsService;
    private readonly IAttachmentFileEatingRepository _attachmentFileEatingRepository;
    private readonly IScheduledPlaceToEatService _scheduledPlaceToEatService;
    private readonly UserService _userService;
    private readonly IMapper _mapper;

    public AttachmentFileEatingService(
      AssetsService assetsService,
      IAttachmentFileEatingRepository attachmentFileEatingRepository,
      IScheduledPlaceToEatService scheduledPlaceToEatService,
      UserService userService,
      IMapper mapper)
    {
      _assetsService = assetsService;
      _attachmentFileEatingRepository = attachmentFileEatingRepository;
      _scheduledPlaceToEatService = scheduledPlaceToEatService;
      _userService = userService;
      _mapper = mapper;
    }

    public async void Create([ValidFileSize(Consts.MaxEatingFileSize)] IFormFile file, int eatingId, int userId)
    {
      if(_userService.GetUser(userId) != null && _scheduledPlaceToEatService.GetEatingById(eatingId) != null)
      {
        var fileName = await _assetsService.SaveFileAsync(file, AssetType.FileEating);
        _attachmentFileEatingRepository.CreateAttachmentFileEating(new Entities.Models.AttachmentFileEating { Path = fileName, ScheduledPlaceToEatId = eatingId });
      }
    }

    public void DeleteFilesEating(int eatingId, int userId)
    {
      if(_userService.GetUser(userId) != null && _scheduledPlaceToEatService.GetEatingById(eatingId) != null)
      {
        foreach(var file in _attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(eatingId))
        {
          _assetsService.DeleteFile(file.Path, AssetType.FileEating);
          _attachmentFileEatingRepository.DeleteAttachmentFileEating(file.Id);
        }
      }
    }

    public void Delete(int fileId, int userId)
    {
      var attachmentFileEating = _attachmentFileEatingRepository.GetAttachmentFileEatingById(fileId);
      if(_userService.GetUser(userId) != null && attachmentFileEating != null && attachmentFileEating.ScheduledPlaceToEat.UserId == userId)
      {
        _assetsService.DeleteFile(attachmentFileEating.Path, AssetType.FileEating);
        _attachmentFileEatingRepository.DeleteAttachmentFileEating(attachmentFileEating.Id);
      }
    }

    public IEnumerable<AttachmentFileEatingDTO> GetAttachmentFileEatingByScheduledPlaceId(int id)
    {
      return _mapper.Map<IEnumerable<AttachmentFileEatingDTO>>(_attachmentFileEatingRepository.GetAttachmentFileEatingByScheduledPlaceId(id));
    }
  }
}
