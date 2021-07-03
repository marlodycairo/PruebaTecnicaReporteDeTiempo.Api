using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Application
{
    public interface ILoginApplication
    {
        string GenerateJSONWebToken(LoginViewModel userInfo);
        LoginViewModel AuthenticateUser(LoginViewModel login);
    }
}
