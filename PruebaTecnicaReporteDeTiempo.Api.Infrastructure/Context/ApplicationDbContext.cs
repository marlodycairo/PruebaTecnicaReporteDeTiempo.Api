using Microsoft.EntityFrameworkCore;
using PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaReporteDeTiempo.Api.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Actividades> Actividades { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
