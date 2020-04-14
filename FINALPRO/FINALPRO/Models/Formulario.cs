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
        public int id { get; set; }

        [Required]
        public String cedula { get; set; }

        [Required]
        public String nombre { get; set; }

        [Required]
        public String apellido { get; set; }

        [Range(16, 100)]
        public int edad { get; set; }
        public String telefono { get; set; }

        [EmailAddress]
        public String correo { get; set; }
        public bool genero { get; set; }
        public String puesto { get; set; }
        public String foto { get; set; }
        public String curriculum { get; set; }
    }
}