using System;
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
    public User FindUserByRecoveryPasswordToken(string token)
    {
      return RepositoryContext.Users.FirstOrDefault(u => u.ResetPasswordToken.Equals(token));
    }

    public void CreateAndSetRecoveryPasswordToken(string email)
    {
      var user = FindUserByEmail(email);
      if(user != null)
      {
        do
        {
          int Length = 30;
          var Alphabet = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm.-0123456789";
          Random rnd = new Random();
          System.Text.StringBuilder sb = new System.Text.StringBuilder(Length - 1);
          for(int i = 0; i < Length; i++)
          {
            int Position = rnd.Next(0, Alphabet.Length - 1);
            sb.Append(Alphabet[Position]);
          }
          user.ResetPasswordToken = sb.ToString();
        } while(FindUserByRecoveryPasswordToken(user.ResetPasswordToken) != null);
        UpdateUser(user);
      }
    }
    public void DeleteRecoveryPasswordToken(string token)
    {
      var user = FindUserByRecoveryPasswordToken(token);
      user.ResetPasswordToken = "";
      UpdateUser(user);
    }
  }
}