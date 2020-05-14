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
            if (CryptoUtils.VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }

        public bool FindUser(string email)
        {
            return _userRepository.FindUserByEmail(email) == null ? false : true;
        }

        public void NewUser(string email, string password)
        {
            var user = new User
            {
                Email = email,
                Password = CryptoUtils.HashPassword(password)
            };
            
            _userRepository.NewUser(user);
        }
    }
}