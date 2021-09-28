using API.Models.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.DataManager
{
    public class PermisoManager : IDataRepositorio<Permiso>
    {
        readonly PermisoContext _permisoContext;

        public PermisoManager(PermisoContext permisoContext)
        {
            this._permisoContext = permisoContext;
        }
        public IEnumerable<Permiso> GetAll()
        {
            return _permisoContext.Permiso.ToList();
        }

        public Permiso Get(long id)
        {
            return _permisoContext.Permiso
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(Permiso entity)
        {
            _permisoContext.Permiso.Add(entity);
            _permisoContext.SaveChanges();
        }
        public void Update(Permiso permiso, Permiso entity)
        {
            permiso.Nombre = entity.Nombre;
            permiso.Apellidos = entity.Apellidos;
            permiso.FechaPermiso = entity.FechaPermiso;
            permiso.TipoPermisoId = entity.TipoPermisoId;
            
            _permisoContext.SaveChanges();
        }
        public void Delete(Permiso permiso)
        {
            _permisoContext.Permiso.Remove(permiso);
            _permisoContext.SaveChanges();
        }

        public async Task<IEnumerable<Permiso>> GetAllAsync()
        {
            return await _permisoContext.Permiso.ToListAsync();
        }

        public async Task<Permiso> GetAsync(long id)
        {
            return await _permisoContext.Permiso
                  .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task AddAsync(Permiso entity)
        {
            _permisoContext.Permiso.Add(entity);
            await _permisoContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Permiso permiso, Permiso entity)
        {
            permiso.Nombre = entity.Nombre;
            permiso.Apellidos = entity.Apellidos;
            permiso.FechaPermiso = entity.FechaPermiso;
            permiso.TipoPermisoId = entity.TipoPermisoId;

            await _permisoContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Permiso permiso)
        {
            _permisoContext.Permiso.Remove(permiso);
            await _permisoContext.SaveChangesAsync();
        }

    }
}
