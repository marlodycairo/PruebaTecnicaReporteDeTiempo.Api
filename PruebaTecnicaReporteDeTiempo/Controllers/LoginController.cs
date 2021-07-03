using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaReporteDeTiempo.Api.Application;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaReporteDeTiempo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginApplication loginApplication;

        public LoginController(ILoginApplication loginApplication)
        {
            this.loginApplication = loginApplication;
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login)
        {
            ActionResult response = Unauthorized();

            var user = loginApplication.AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = loginApplication.GenerateJSONWebToken(user);

                response = Ok(new { token = tokenString });
            }

            return response;
        }
    }
}
