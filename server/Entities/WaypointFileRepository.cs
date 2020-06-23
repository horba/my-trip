using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
  public class WaypointFileRepository
  {
    private readonly RepositoryContext _repositoryContext;

    public WaypointFileRepository(RepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<WaypointFile> GetFiles()
    {
      return _repositoryContext.WaypointFiles.AsNoTracking();
    }

    public void CreateFile(WaypointFile waypointFile)
    {
      _repositoryContext.WaypointFiles.Add(waypointFile);
      _repositoryContext.SaveChanges();
    }

    public void DeleteFile(WaypointFile waypointFile)
    {
      _repositoryContext.WaypointFiles.Remove(waypointFile);
      _repositoryContext.SaveChanges();
    }

    public void DeleteRange(IEnumerable<WaypointFile> wpfs)
    {
      _repositoryContext.WaypointFiles.RemoveRange(wpfs);
      _repositoryContext.SaveChanges();
    }

  }
}
