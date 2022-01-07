using System.ComponentModel.DataAnnotations;

namespace WebAmb.Models
{
    public class Paciente    {

        [Key]
        public int paciente_id { get; set; }

        [Required]
        public string nombre { get; set; } = string.Empty;

        [Required]
        public string apellido1 { get; set; } = string.Empty;

        public string? apellido2 { get; set; }

        [Required]
        public string identificacion { get; set; } = string.Empty;

        [Required]
        public int edad { get; set; }

        [Required]
        public DateTime fechanacimiento { get; set; }

        [Required]
        public string telefono { get; set; } = string.Empty;

        [Required]
        public string direccion { get; set; } = string.Empty;

        [Required]
        public Genero genero { get; set; } = new Genero();


    }
}
