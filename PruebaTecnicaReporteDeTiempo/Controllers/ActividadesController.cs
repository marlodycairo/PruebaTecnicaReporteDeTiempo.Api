using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaReporteDeTiempo.Api.Application;
using PruebaTecnicaReporteDeTiempo.Api.Domain;
using PruebaTecnicaReporteDeTiempo.Api.Domain.Models;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaReporteDeTiempo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {
        private readonly IActividadesApplication actividadesApplication;

        public ActividadesController(IActividadesApplication actividadesApplication)
        {
            this.actividadesApplication = actividadesApplication;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<ActividadesViewModel> VerActividades()
        {
            return actividadesApplication.GetAll();
        }

        [HttpPost]
        [Authorize]
        public ActionResult CrearActividad(Actividades actividades)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            actividadesApplication.Create(actividades);

            return Ok();
        }

        //[HttpGet("{id}")]
        //[Authorize]
        //public ActionResult<ActividadesViewModel> DetallesActividad(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return NotFound();
        //    }
        //    return actividadesApplication.GetById(id);
        //}

        [HttpGet("{idUser}")]
        [Authorize]
        public List<Actividades> GetActivitiesByUser(string idUser)
        {
            return actividadesApplication.GetActivitiesByUser(idUser);
        }
    }
}

