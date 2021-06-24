using AutoMapper;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.DomainServices
{
    public class UsuariosDomainService : IUsuariosDomain
    {
        private readonly IUsuariosRepository usuariosRepositorhy;

        public UsuariosDomainService(IUsuariosRepository usuariosRepositorhy)
        {
            this.usuariosRepositorhy = usuariosRepositorhy;
        }
        public void Login(string user, string pass)
        {
            usuariosRepositorhy.Login(user, pass);
        }
    }
}
