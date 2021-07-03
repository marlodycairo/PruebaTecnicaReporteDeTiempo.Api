using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain
{
    public interface ILoginDomain
    {
        string GenerateJSONWebToken(LoginViewModel userInfo);
        LoginViewModel AuthenticateUser(LoginViewModel login);
    }
}
