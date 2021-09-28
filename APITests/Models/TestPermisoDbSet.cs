using API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers.Tests
{
    class TestPermisoDbSet : TestDbSet<Permiso>
    {
        public override Permiso Find(params object[] keyValues)
        {
            return new Permiso
            {
                Apellidos = "",
                Nombre = "",
                Id = 1,
                FechaPermiso = new DateTime(),
                TipoPermisoId = 1,
            };
        }
    }
}
