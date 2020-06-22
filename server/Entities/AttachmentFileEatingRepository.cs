using System.Collections.Generic;
using System.Linq;
using Entities.Models;

namespace Entities
{
  public class AttachmentFileEatingRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public AttachmentFileEatingRepository(RepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
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
  }
}
