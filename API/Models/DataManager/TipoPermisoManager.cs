using API.Models.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.DataManager
{
    public class TipoPermisoManager : IDataRepositorio<TipoPermiso>
    {
        readonly PermisoContext _permisoContext;

        public TipoPermisoManager(PermisoContext permisoContext)
        {
            this._permisoContext = permisoContext;
        }
        public IEnumerable<TipoPermiso> GetAll()
        {
            return _permisoContext.TipoPermiso.ToList();
        }

        public TipoPermiso Get(long id)
        {
            return _permisoContext.TipoPermiso
                  .FirstOrDefault(e => e.Id == id);
        }
        public void Add(TipoPermiso entity)
        {
            _permisoContext.TipoPermiso.Add(entity);
            _permisoContext.SaveChanges();
        }
        public void Update(TipoPermiso tipoPermiso, TipoPermiso entity)
        {
            tipoPermiso.Descripcion = entity.Descripcion;

            _permisoContext.SaveChanges();
        }
        public void Delete(TipoPermiso tipoPermiso)
        {
            _permisoContext.TipoPermiso.Remove(tipoPermiso);
            _permisoContext.SaveChanges();
        }


        public async Task<IEnumerable<TipoPermiso>> GetAllAsync()
        {
            return await _permisoContext.TipoPermiso.ToListAsync();
        }

        public async Task<TipoPermiso> GetAsync(long id)
        {
            return await _permisoContext.TipoPermiso
                  .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task AddAsync(TipoPermiso entity)
        {
            _permisoContext.TipoPermiso.Add(entity);
            await _permisoContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(TipoPermiso tipoPermiso, TipoPermiso entity)
        {
            tipoPermiso.Descripcion = entity.Descripcion;

            await _permisoContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(TipoPermiso tipoPermiso)
        {
            _permisoContext.TipoPermiso.Remove(tipoPermiso);
            await _permisoContext.SaveChangesAsync();
        }
    }
}
