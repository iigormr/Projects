using System.ComponentModel.DataAnnotations;

namespace Empresa.Models.Empresa
{
    public class Billings
    {
        [Key]
        public int id { get; set; }

        public bool free { get; set; }
        public bool database { get; set; }
    }
}
