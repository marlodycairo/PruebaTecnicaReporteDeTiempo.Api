using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities
{
    public class Usuarios
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string Usuario { get; set; }

        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
