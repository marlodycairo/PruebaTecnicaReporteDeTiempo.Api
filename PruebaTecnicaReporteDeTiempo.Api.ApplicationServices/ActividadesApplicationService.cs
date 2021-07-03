using AutoMapper;
using PruebaTecnicaReporteDeTiempo.Api.Application;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.ApplicationServices
{
    public class ActividadesApplicationService : IActividadesApplication
    {
        private readonly IActividadesDomain actividadesDomain;
        private readonly IMapper mapper;

        public ActividadesApplicationService(IActividadesDomain actividadesDomain, IMapper mapper)
        {
            this.actividadesDomain = actividadesDomain;
            this.mapper = mapper;
        }
        public string Create(Actividades actividades)
        {
            actividadesDomain.Create(actividades);
            var result = mapper.Map<ActividadesViewModel>(actividades);
            return result.ToString();
        }

        public IEnumerable<ActividadesViewModel> GetAll()
        {
            var actividades = actividadesDomain.GetAll();

            var result = mapper.Map<IEnumerable<ActividadesViewModel>>(actividades);

            return result;
        }

        public ActividadesViewModel GetById(int id)
        {
            var actividad = actividadesDomain.GetById(id);

            var result = mapper.Map<ActividadesViewModel>(actividad);

            return result;
        }

        public List<Actividades> GetActivitiesByUser(string idUser)
        {
            return actividadesDomain.GetActivitiesByUser(idUser);
        }
    }
}
