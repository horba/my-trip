using Microsoft.AspNetCore.Http;

namespace WebAPI.Interfaces
{
  public interface IAttachmentFileEatingService
  {
    public void Create(IFormFile file, int eatingId, int userId);

    public void DeleteFilesEating(int eatingId, int userId);

    public void Delete(int fileId, int userId);
  }
}
