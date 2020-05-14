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

        public void NewUser(User user)
        {
            RepositoryContext.Users.Add(user);
            RepositoryContext.SaveChanges();
        }
    }
}