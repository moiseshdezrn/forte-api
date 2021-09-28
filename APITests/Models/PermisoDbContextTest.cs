using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers.Tests
{
    public class PermisoDbContextTest : IDisposable
    {
        public PermisoDbContextTest()
        {
            this.Permiso = new TestDbSet<Permiso>();
        }

        public DbSet<Permiso> Permiso { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Permiso item) { }
        public void Dispose() { }
    }
}
