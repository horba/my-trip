using Entities.Models;
using System.Linq;

namespace Entities
{
  public interface IEntertainmentRepository
  {
    IQueryable<Entertainment> GetUserEntertainments(int userId);
    Entertainment GetEntertainmentById(int id);
    void CreateEntertainment(Entertainment entertainment);
    void UpdateEntertainment(Entertainment entertainment);
  }

  public class EntertainmentRepository: IEntertainmentRepository
  {
    private readonly IRepositoryContext RepositoryContext;

    public EntertainmentRepository(IRepositoryContext repositoryContext)
    {
      RepositoryContext = repositoryContext;
    }

    public IQueryable<Entertainment> GetUserEntertainments(int userId)
    {
      return RepositoryContext.Entertainments
        .Where(e => e.UserId.Equals(userId));
    }

    public Entertainment GetEntertainmentById(int id)
    {
      return RepositoryContext.Entertainments
        .FirstOrDefault(e => e.Id.Equals(id));
    }

    public void CreateEntertainment(Entertainment entertainment)
    {
      RepositoryContext.Entertainments.Add(entertainment);
      RepositoryContext.SaveChanges();
    }

    public void UpdateEntertainment(Entertainment entertainment)
    {
      RepositoryContext.Entertainments.Update(entertainment);
      RepositoryContext.SaveChanges();
    }
  }
}
