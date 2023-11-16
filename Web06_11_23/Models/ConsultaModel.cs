using System.ComponentModel.DataAnnotations;

namespace Web06_11_23.Models
{
    public class ConsultaModel : Paciente
    {
        [Key]
        public int idConsulta { get; set; }
        public int idPaciente { get; set; }
        public string Ficha { get; set; }
        public string DataConsulta { get; set; }

        public List<Paciente> ListaPaciente { get; set; }
        public List<Consulta> Consulta { get; set; }

    }
}
