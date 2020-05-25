using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Models;

namespace Entities
{
  public class LanguageRepository
  {
    private readonly RepositoryContext RepositoryContext;

    public LanguageRepository(RepositoryContext repositoryContext)
    {
      this.RepositoryContext = repositoryContext;
    }

    public Language FindLanguageById(int id)
    {
      return RepositoryContext.Languages.FirstOrDefault(language => language.Id.Equals(id));
    }
  }
}
