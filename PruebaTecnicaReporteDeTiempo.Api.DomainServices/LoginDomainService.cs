using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Context;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaReporteDeTiempo.Api.DomainServices
{
    public class LoginDomainService : ILoginDomain
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;
        private readonly IRolesRepository rolesRepository;

        public LoginDomainService(ApplicationDbContext context, IConfiguration configuration, IRolesRepository rolesRepository)
        {
            this.context = context;
            this.configuration = configuration;
            this.rolesRepository = rolesRepository;
        }

        public string GenerateJSONWebToken(LoginViewModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var usuario = context.Usuarios.FirstOrDefault(p => p.Usuario == userInfo.Usuario);

            var roles = rolesRepository.ObtenerRolesPorUsuarios(usuario.Id);

            var claims = new Claim[] { };

            foreach (var rol in roles)
            {
                claims = new Claim[]
                {
                    new Claim(ClaimTypes.Role, rol),
                    new Claim(ClaimTypes.Email, userInfo.Usuario),
                    new Claim(JwtRegisteredClaimNames.Iss, "https://localhost:44310/login/"),
                    new Claim(JwtRegisteredClaimNames.Sub, userInfo.Usuario),
                    new Claim(JwtRegisteredClaimNames.Email, userInfo.Usuario),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
            }

            var token = new JwtSecurityToken(configuration["Jwt.Issuer"], configuration["Jwt:Issuer"], claims, expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public LoginViewModel AuthenticateUser(LoginViewModel login)
        {
            LoginViewModel user = null;

            IEnumerable<Usuarios> usuarios;

            usuarios = from p in context.Usuarios
                       where p.Usuario == login.Usuario
                       select p;

            if (login.Usuario == usuarios.First().Usuario)
            {
                user = new LoginViewModel { Usuario = usuarios.First().Usuario, Contraseña = usuarios.First().Contraseña };
            }

            return user;
        }
    }
}
