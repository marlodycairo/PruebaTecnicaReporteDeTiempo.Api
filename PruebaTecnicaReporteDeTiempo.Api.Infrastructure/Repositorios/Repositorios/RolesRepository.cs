using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Context;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.Repositorios
{
    public class RolesRepository : IRolesRepository
    {
        private readonly ApplicationDbContext context;

        public RolesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<string> ObtenerRolesPorUsuarios(int userId)
        {
            return (from userRol in context.UsuarioRol
                    join rol in context.Rol
                    on userRol.RolId equals rol.Id
                    where userRol.UsuarioId == userId
                    select rol.Nombre).ToList();
        }
    }
}
