using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Application
{
    public interface IActividadesApplication
    {
        string Create(Actividades actividades);
        IEnumerable<ActividadesViewModel> GetAll();
        ActividadesViewModel GetById(int id);
        List<Actividades> GetActivitiesByUser(string idUser);
    }
}
