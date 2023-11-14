using System.ComponentModel.DataAnnotations;

namespace Web06_11_23.Models
{
    public class Paciente
    {
        [Key]
        public int idPaciente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
