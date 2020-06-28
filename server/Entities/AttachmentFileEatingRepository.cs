using System.Collections.Generic;
using System.Linq;
using Entities.Interfaces;
using Entities.Models;

namespace Entities
{
  public class AttachmentFileEatingRepository: IAttachmentFileEatingRepository
  {
    private readonly IRepositoryContext RepositoryContext;

    public AttachmentFileEatingRepository(IRepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }

    public AttachmentFileEating GetAttachmentFileEatingById(int Id)
    {
      return RepositoryContext.AttachmentFilesEating.FirstOrDefault(u => u.Id.Equals(Id));
    }

    public IEnumerable<AttachmentFileEating> GetAttachmentFileEatingByScheduledPlaceId(int ScheduledPlaceId)
    {
      return RepositoryContext.AttachmentFilesEating.Where(u => u.ScheduledPlaceToEatId.Equals(ScheduledPlaceId));
    }

    public void CreateAttachmentFileEating(AttachmentFileEating attachmentFileEating)
    {
      RepositoryContext.AttachmentFilesEating.Add(attachmentFileEating);
      RepositoryContext.SaveChanges();
    }

    public void UpdateAttachmentFileEating(AttachmentFileEating attachmentFileEating)
    {
      RepositoryContext.AttachmentFilesEating.Update(attachmentFileEating);
      RepositoryContext.SaveChanges();
    }

    public void DeleteAttachmentFileEating(AttachmentFileEating attachmentFileEating)
    {
      RepositoryContext.AttachmentFilesEating.Remove(attachmentFileEating);
      RepositoryContext.SaveChanges();
    }

    public void DeleteAttachmentFileEating(int id)
    {
      DeleteAttachmentFileEating(RepositoryContext.AttachmentFilesEating.FirstOrDefault(r => r.Id.Equals(id)));
    }
  }
}
