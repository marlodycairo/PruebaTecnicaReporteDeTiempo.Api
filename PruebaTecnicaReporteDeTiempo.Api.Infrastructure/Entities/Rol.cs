using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
