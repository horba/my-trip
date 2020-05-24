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

        public void UpdateUserPassword(User user, string password)
        {
            user = FindUserByEmail(user.Email);
            user.Password = password;
            RepositoryContext.SaveChanges();
        }
    }
}