using System.ComponentModel.DataAnnotations;

namespace Web06_11_23.Models
{
    public class Consulta
    {
        [Key]
        public int idConsulta { get; set; }
        public int idPaciente { get; set; }
        public string Ficha { get; set; }
        public string DataConsulta { get; set; }
    }
}
