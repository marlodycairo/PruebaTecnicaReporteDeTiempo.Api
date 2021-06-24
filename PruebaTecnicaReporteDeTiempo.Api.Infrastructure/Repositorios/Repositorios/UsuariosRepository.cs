using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Context;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.Repositorios
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ApplicationDbContext context;

        public UsuariosRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Login(string user, string pass)
        {
            var oUser = (from p in context.Usuarios
                         where p.Usuario == user && p.Contraseña == pass
                         select p).FirstOrDefault();
        }
    }
}
