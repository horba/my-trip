using Entities;
using Entities.Models;

namespace WebAPI.Services
{
    public class UserService
    {
        
        private UserRepository _userRepository;
        
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User getUser(string email, string password)
        {
            return _userRepository.findByEmailAndPassword(email, password);
        }
    }
}