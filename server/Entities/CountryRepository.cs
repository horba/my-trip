using System.Linq;
using Entities.Interfaces;
using Entities.Models;

namespace Entities
{
  public class CountryRepository
  {
    private readonly IRepositoryContext RepositoryContext;

    public CountryRepository(IRepositoryContext repositoryContext)
    {
      this.RepositoryContext = repositoryContext;
    }

    public Country FindCountryById(int id)
    {
      return RepositoryContext.Countries.FirstOrDefault(country => country.Id.Equals(id));
    }
  }
}
