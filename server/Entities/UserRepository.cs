using System.Linq;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
  public class UserRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public UserRepository(RepositoryContext repositoryContext)
    {
      this.RepositoryContext = repositoryContext;
    }

    public User FindUserByEmail(string email)
    {
      return RepositoryContext.Users.FirstOrDefault(u => u.Email.Equals(email));
    }

    public User FindUserById(int id)
    {
      return RepositoryContext.Users
        .Include(u => u.Country)
        .Include(u => u.Language)
        .FirstOrDefault(u => u.Id.Equals(id));
    }

    public void CreateUser(User user)
    {
      RepositoryContext.Users.Add(user);
      RepositoryContext.SaveChanges();
    }

    public void UpdateUser(User user)
    {
      RepositoryContext.Users.Update(user);
      RepositoryContext.SaveChanges();
    }
  }
}