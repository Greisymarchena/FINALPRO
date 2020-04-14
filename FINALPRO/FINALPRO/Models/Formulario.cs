using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FINALPRO.Models
{
    public class Formulario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Cedula { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        public String Apellido { get; set; }

        [Range(16, 100)]
        public int Edad { get; set; }
        public String Telefono { get; set; }

        [EmailAddress]
        public String Correo { get; set; }
        public bool Genero { get; set; }
        public String Puesto { get; set; }
        public String Foto { get; set; }
        public String Curriculum { get; set; }
    }
}