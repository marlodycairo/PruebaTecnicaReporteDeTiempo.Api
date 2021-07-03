using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities
{
    public class UsuarioRol
    {
        [ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
    }
}
