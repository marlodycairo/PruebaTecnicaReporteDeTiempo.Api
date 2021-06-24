using AutoMapper;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.DomainServices
{
    public class ActividadesDomainService : IActividadesDomain
    {
        private readonly IActividadesRepository actividadesRepository;
        private readonly IMapper mapper;

        public ActividadesDomainService(IActividadesRepository actividadesRepository, IMapper mapper)
        {
            this.actividadesRepository = actividadesRepository;
            this.mapper = mapper;
        }
        public string Create(Actividades actividades)
        {
            actividadesRepository.Create(actividades);
            var result = mapper.Map<ActividadesViewModel>(actividades);
            return result.ToString();
        }

        public IEnumerable<ActividadesViewModel> GetAll()
        {
            var actividades = actividadesRepository.GetAll();

            var result = mapper.Map<IEnumerable<ActividadesViewModel>>(actividades);

            return result;
        }

        public ActividadesViewModel GetById(int id)
        {
            var actividad = actividadesRepository.GetById(id);

            var result = mapper.Map<ActividadesViewModel>(actividad);

            return result;
        }
    }
}
