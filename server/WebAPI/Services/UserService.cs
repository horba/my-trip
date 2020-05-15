using Entities;
using Entities.Models;
using System;
using System.Security.Cryptography;
using System.Text;

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
            if (user != null && CryptoUtils.VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }

        public bool IsUserExist(string email)
        {
            return _userRepository.FindUserByEmail(email) == null ? false : true;
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
    }
}