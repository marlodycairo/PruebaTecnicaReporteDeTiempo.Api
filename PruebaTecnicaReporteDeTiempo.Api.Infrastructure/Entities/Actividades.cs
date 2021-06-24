using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities
{
    public class Actividades
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        public double TiempoReportado { get; set; }
    }
}
