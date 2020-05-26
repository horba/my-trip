using System;
using System.Linq;
using Entities.Models;

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

    public void CreateUser(User user)
    {
      RepositoryContext.Users.Add(user);
      RepositoryContext.SaveChanges();
    }

    public void UpdateUserPassword(string email, string password)
    {
      try
      {
        if(email == "" || password == "" || password.Length < 8)
        {
          if(email == "")
          {
            throw new ArgumentException("variable email is empty", "email");
          }
          if(password == "")
          {
            throw new ArgumentException("variable password is empty", "password");
          }
          if(password.Length < 8)
          {
            throw new ArgumentException("variable password is not valid. password length must be >= 8", "password");
          }
        }
        var user = FindUserByEmail(email);
        user.Password = password;
        RepositoryContext.SaveChanges();
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.ParamName + e.Message);
        throw;
      }
      catch(Exception)
      {
        throw;
      }
    }
  }
}