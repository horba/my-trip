using System.Collections.Generic;
using System.Linq;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class TicketsRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public TicketsRepository(RepositoryContext repositoryContext )
        {
            _repositoryContext = repositoryContext;
        }

        public List<Ticket> GetTickets(User user)
        {
            return _repositoryContext.Tickets
                .Where(t => t.UserId.Equals(user.Id))
                .Include(t => t.Routes)
                .ToList();
        }
    }
}
