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
    private readonly IRepositoryContext _repositoryContext;

    public EntertainmentRepository(IRepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
    }

    public IQueryable<Entertainment> GetUserEntertainments(int userId)
    {
      return _repositoryContext.Entertainments
        .Where(e => e.UserId.Equals(userId));
    }

    public Entertainment GetEntertainmentById(int id)
    {
      return _repositoryContext.Entertainments
        .FirstOrDefault(e => e.Id.Equals(id));
    }

    public void CreateEntertainment(Entertainment entertainment)
    {
      _repositoryContext.Entertainments.Add(entertainment);
      _repositoryContext.SaveChanges();
    }

    public void UpdateEntertainment(Entertainment entertainment)
    {
      _repositoryContext.Entertainments.Update(entertainment);
      _repositoryContext.SaveChanges();
    }
  }
}
