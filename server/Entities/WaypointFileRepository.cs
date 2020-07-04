using System.Linq;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models
{
  public interface IWaypointFileRepository
  {
    IQueryable<WaypointFile> GetFiles();
    void CreateFile(WaypointFile waypointFile);
    void DeleteFile(WaypointFile waypointFile);
  }

  public class WaypointFileRepository : IWaypointFileRepository
  {
    private readonly IRepositoryContext _repositoryContext;

    public WaypointFileRepository(IRepositoryContext repositoryContext)
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

  }
}
