using System.Linq;
using Entities.Models;

namespace Entities.Interfaces
{
  public interface IAttachmentFileEatingRepository
  {
    public AttachmentFileEating GetAttachmentFileEatingById(int Id);

    public IQueryable<AttachmentFileEating> GetAttachmentFileEatingByScheduledPlaceId(int ScheduledPlaceId);

    public void CreateAttachmentFileEating(AttachmentFileEating attachmentFileEating);

    public void UpdateAttachmentFileEating(AttachmentFileEating attachmentFileEating);

    public void DeleteAttachmentFileEating(int id);
  }
}
