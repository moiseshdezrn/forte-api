using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PermisoContext : DbContext
    {
        public PermisoContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<TipoPermiso> TipoPermiso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoPermiso>()
                .HasData(
                    new TipoPermiso { Id = 1, Descripcion = "Enfermedad" },
                    new TipoPermiso { Id = 2, Descripcion = "Diligencia" },
                    new TipoPermiso { Id = 3, Descripcion = "Otros" }
                );
        }
    }
}
