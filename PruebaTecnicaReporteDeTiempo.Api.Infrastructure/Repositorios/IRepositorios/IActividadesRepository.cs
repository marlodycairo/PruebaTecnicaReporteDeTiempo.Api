using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios
{
    public interface IActividadesRepository
    {
        string Create(Actividades actividades);
        IEnumerable<Actividades> GetAll();
        Actividades GetById(int id);

        List<Actividades> GetActivitiesByUser(string idUser);
    }
}
