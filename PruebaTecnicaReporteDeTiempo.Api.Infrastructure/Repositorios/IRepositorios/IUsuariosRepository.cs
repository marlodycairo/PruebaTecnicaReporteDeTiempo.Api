using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios
{
    public interface IUsuariosRepository
    {
        void Login(string user, string pass);
    }
}
