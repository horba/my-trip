using System.Collections.Generic;
using System.Linq;
using Entities.Interfaces;
using Entities.Models;

namespace Entities
{
  public class AttachmentFileEatingRepository: IAttachmentFileEatingRepository
  {
    private readonly IRepositoryContext _repositoryContext;

    public AttachmentFileEatingRepository(IRepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public AttachmentFileEating GetAttachmentFileEatingById(int Id)
    {
      return _repositoryContext.AttachmentFilesEating.FirstOrDefault(u => u.Id.Equals(Id));
    }

    public IQueryable<AttachmentFileEating> GetAttachmentFileEatingByScheduledPlaceId(int ScheduledPlaceId)
    {
      return _repositoryContext.AttachmentFilesEating.Where(u => u.ScheduledPlaceToEatId.Equals(ScheduledPlaceId));
    }

    public void CreateAttachmentFileEating(AttachmentFileEating attachmentFileEating)
    {
      _repositoryContext.AttachmentFilesEating.Add(attachmentFileEating);
      _repositoryContext.SaveChanges();
    }

    public void UpdateAttachmentFileEating(AttachmentFileEating attachmentFileEating)
    {
      _repositoryContext.AttachmentFilesEating.Update(attachmentFileEating);
      _repositoryContext.SaveChanges();
    }

    public void DeleteAttachmentFileEating(int id)
    {
      var attachmentFileEating = _repositoryContext.AttachmentFilesEating.FirstOrDefault(r => r.Id.Equals(id));
      if(attachmentFileEating != null)
      {
        _repositoryContext.AttachmentFilesEating.Remove(attachmentFileEating);
        _repositoryContext.SaveChanges();
      }
    }
  }
}
