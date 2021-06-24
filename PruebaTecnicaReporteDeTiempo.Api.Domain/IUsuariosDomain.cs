using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain
{
    public interface IUsuariosDomain
    {
        void Login(string user, string pass);
    }
}
