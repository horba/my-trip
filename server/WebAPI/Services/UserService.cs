using Entities;
using Entities.Models;
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using Entities.Models.Enums;
using WebAPI.DTO.UserSettings;

namespace WebAPI.Services
{
  public class UserService
  {

    private readonly UserRepository _userRepository;
    private readonly CountryRepository _countryRepository;
    private readonly LanguageRepository _languageRepository;

    public UserService(UserRepository userRepository, CountryRepository countryRepository, LanguageRepository languageRepository)
    {
      _userRepository = userRepository;
      _countryRepository = countryRepository;
      _languageRepository = languageRepository;
    }

    public User GetUser(string email, string password)
    {
      var user = _userRepository.FindUserByEmail(email);
      if (user != null && CryptoUtils.VerifyPassword(password, user.Password))
      {
        return user;
      }
      return null;
    }

    public bool IsUserExist(string email)
    {
      return _userRepository.FindUserByEmail(email) != null;
    }

    public User GetUser(string email)
    {
      return _userRepository.FindUserByEmail(email);
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

    public void CreateOauthUser(string email)
    {
      var user = new User {Email = email, IsOauth = true};
      _userRepository.CreateUser(user);
    }

    public UserSettingsDTO ConvertUserToUserSettingsDTO(User user)
    {
      return new UserSettingsDTO
      {
        FirstName = user.FirstName,
        LastName = user.LastName,
        Email = user.Email,
        Gender = user.Gender,
        CountryId = user.Country?.Id,
        LanguageId = user.Language?.Id
      };
    }

    public void ApplyUserSettingsDTOToUser(User user, UserSettingsDTO userSettingsDTO)
    {
      user.FirstName = userSettingsDTO.FirstName;
      user.LastName = userSettingsDTO.LastName;
      user.Email = userSettingsDTO.Email;
      user.Gender = userSettingsDTO.Gender;
      user.Country = userSettingsDTO.CountryId != null ? _countryRepository.FindCountryById((int)userSettingsDTO.CountryId) : null;
      user.Language = userSettingsDTO.LanguageId != null ? _languageRepository.FindLanguageById((int)userSettingsDTO.LanguageId) : null;
    }
    public bool UpdateUserPassword(string email, string newPassword)
    {
      try
      {
        if(IsUserExist(email))
        {
          var password = CryptoUtils.HashPassword(newPassword);
          var user = _userRepository.FindUserByEmail(email);
          user.Password = password;
          _userRepository.UpdateUser(user);
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
    public bool IsRecoveryPasswordTokenExist(string token)
    {
      return _userRepository.FindUserByRecoveryPasswordToken(token) != null;
    }
    public void CreateRecoveryPasswordToken(string email)
    {
      _userRepository.CreateAndSetRecoveryPasswordToken(email);
    }
    public void DeleteRecoveryPasswordToken(string token)
    {
      if(IsRecoveryPasswordTokenExist(token))
      {
        _userRepository.DeleteRecoveryPasswordToken(token);
      }
    }
    public User GetUserByRecoveryPasswordToken(string token)
    {
      return _userRepository.FindUserByRecoveryPasswordToken(token);
    }
  }
}