using Entities;
using Entities.Models;

namespace WebAPI.Services
{
  public class UserService
  {

    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public User GetUser(string email, string password)
    {
      var user = _userRepository.FindUserByEmail(email);
      if(user != null && CryptoUtils.VerifyPassword(password, user.Password))
      {
        return user;
      }
      return null;
    }

    public bool IsUserExist(string email)
    {
      return _userRepository.FindUserByEmail(email) != null;
    }

    public void CreateUser(string email, string password)
    {
      var user = new User
      {
        Email = email,
        Password = CryptoUtils.HashPassword(password)
      };

      _userRepository.CreateUser(user);
    }
    public User GetUser(string email)
    {
      return _userRepository.FindUserByEmail(email);
    }

    public bool UpdateUserPassword(string email, string newPassword)
    {
      try
      {
        var user = GetUser(email);
        if(user != null)
        {
          var password = CryptoUtils.HashPassword(newPassword);
          _userRepository.UpdateUserPassword(user, password);
          return true;
        }
        else
        {
          CreateUser(email, newPassword);
          return true;
        }
      }
      catch
      {
        return false;
      }
    }

  }
}