using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using WebAPI.DTO.ScheduledPlaceToEat;

namespace WebAPI.Interfaces
{
  public interface IAttachmentFileEatingService
  {
    public void Create([ValidFileSize(Services.Assets.Consts.MaxEatingFileSize)] IFormFile file, int eatingId, int userId);

    public void DeleteFilesEating(int eatingId, int userId);

    public void Delete(int fileId, int userId);

    public IEnumerable<AttachmentFileEatingDTO> GetAttachmentFileEatingByScheduledPlaceId(int id);
  }
}
