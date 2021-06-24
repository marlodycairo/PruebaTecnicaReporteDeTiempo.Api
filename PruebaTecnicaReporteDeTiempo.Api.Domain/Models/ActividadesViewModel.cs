using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain.Models
{
    public class ActividadesViewModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        public double TiempoReportado { get; set; }
    }
}
