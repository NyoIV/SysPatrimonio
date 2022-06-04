using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SysPatrimonio.Models
{
    [Table("local", Schema = "public")]
    public class DbLocal { 
        public int id { get; set; }
        public string nomelocal { get; set; }
        public string descricaolocal { get; set; }
    }
    
}
