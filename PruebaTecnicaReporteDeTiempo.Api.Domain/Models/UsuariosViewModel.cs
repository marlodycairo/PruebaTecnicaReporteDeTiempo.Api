using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain.Models
{
    public class UsuariosViewModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
