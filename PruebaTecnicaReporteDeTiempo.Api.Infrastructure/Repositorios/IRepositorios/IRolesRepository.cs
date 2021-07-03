using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios
{
    public interface IRolesRepository
    {
        List<string> ObtenerRolesPorUsuarios(int userId);
    }
}
