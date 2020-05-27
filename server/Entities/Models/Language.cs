using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
  [Table("languages")]
  public class Language
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }
}
