using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Context;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.IRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Repositorios.Repositorios
{
    public class ActividadesRepository : IActividadesRepository
    {
        private readonly ApplicationDbContext context;

        public ActividadesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public string Create(Actividades actividades)
        {
            var query = (from p in context.Actividades
                         where p.Descripcion == actividades.Descripcion && p.IdUsuario == actividades.IdUsuario
                         select p.TiempoReportado).Sum();
            if (query > 8)
            {
                string msgError = "Valor no válido. El tiempo reportado no puede ser mayor de 8 horas";

                return msgError;
            }
            context.Actividades.Add(actividades);
            context.SaveChanges();

            var msg = "Actividad guardada con éxito.";

            return msg;
        }

        public IEnumerable<Actividades> GetAll()
        {
            return context.Actividades.ToList();
        }

        public Actividades GetById(int id)
        {
            return context.Actividades.Find(id);
        }

        public List<Actividades> GetActivitiesByUser(string idUser)
        {
            return (from user in context.Usuarios
                    join actividad in context.Actividades
                    on user.Id equals actividad.IdUsuario
                    where user.Usuario == idUser
                    select actividad).ToList();
        }
    }
}
