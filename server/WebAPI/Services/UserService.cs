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

        public User IsUser(string email)
        {
            var user = _userRepository.FindUserByEmail(email);
            return user;
        }
    }
}