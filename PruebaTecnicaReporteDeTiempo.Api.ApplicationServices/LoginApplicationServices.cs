using PruebaTecnicaReporteDeTiempo.Api.Application;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.ApplicationServices
{
    public class LoginApplicationServices : ILoginApplication
    {
        private readonly ILoginDomain loginDomain;

        public LoginApplicationServices(ILoginDomain loginDomain)
        {
            this.loginDomain = loginDomain;
        }
        public LoginViewModel AuthenticateUser(LoginViewModel login)
        {
            return loginDomain.AuthenticateUser(login);
        }

        public string GenerateJSONWebToken(LoginViewModel userInfo)
        {
            return loginDomain.GenerateJSONWebToken(userInfo);
        }
    }
}
