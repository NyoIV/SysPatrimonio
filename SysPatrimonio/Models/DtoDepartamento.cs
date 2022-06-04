using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysPatrimonio.Models
{
   
    public class DtoDepartamento
    {
        [Key]

        public int id { get; set; }
        public string? nomedepartamento { get; set; }
        public string? descricaodepartamento { get; set; }
        public string? nomelocal { get; set; }
    }
}
