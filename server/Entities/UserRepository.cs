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

        public User findByEmailAndPassword(string email, string password)
        {
            return RepositoryContext.Users.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
        }
    }
}