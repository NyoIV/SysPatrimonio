using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SysPatrimonio.Models
{
    [Table("fornecedor", Schema = "public")]
    public class DbPatrimonio
    {
        public int id { get; set; }
        public int idcategoria { get; set; }
        public int idlocal { get; set; }
        public int iddepartamento { get; set; }
        public string numetiqueta   { get; set; }
        public string nomepatrimonio { get; set; }
        public string descricaopatrimonio  { get; set; }
        public decimal valorpatrimonio { get; set; }
        public string marcamodelo { get; set; }
        public DateTime? dataaquisicao { get; set; }
        public DateTime? databaixa { get; set; }

    }
}
