using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities
{
    public class Usuarios
    {
        [ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Usuario no válido")]
        [DataType(DataType.EmailAddress)]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Contraseña no válida")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
