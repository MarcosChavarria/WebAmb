using System.ComponentModel.DataAnnotations;

namespace WebAmb.Models
{
    public class Genero    {

        [Key]
        public int genero_id { get; set; }

        [Required]
        public string code { get; set; } = string.Empty;


        [Required]
        public string name { get; set; } = string.Empty;

        [Required]
        public string desc { get; set; } = string.Empty;




    }
}
