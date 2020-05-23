using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("countries")]
  public class Country
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameUa { get; set; }
    public string NameRu { get; set; }
  }
}
