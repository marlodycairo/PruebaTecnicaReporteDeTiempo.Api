using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IActividadesDomain actividadesDomain;

        public ActividadesController(IActividadesDomain actividadesDomain)
        {
            this.actividadesDomain = actividadesDomain;
        }

        [HttpGet]
        public IEnumerable<ActividadesViewModel> VerActividades()
        {
            return actividadesDomain.GetAll();
        }

        [HttpPost]
        public ActionResult CrearActividad(Actividades actividades)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            actividadesDomain.Create(actividades);

            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<ActividadesViewModel> DetallesActividad(int id)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return actividadesDomain.GetById(id);
        }
    }
}
