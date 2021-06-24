using AutoMapper;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Domain.Mappers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Actividades, ActividadesViewModel>();
            CreateMap<ActividadesViewModel, Actividades>();

            CreateMap<Usuarios, UsuariosViewModel>();
            CreateMap<UsuariosViewModel, Usuarios>();
        }
    }
}
