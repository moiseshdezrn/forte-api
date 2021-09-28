using API.Models;
using API.Models.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
        private readonly IDataRepositorio<Permiso> _dataRepository;
        public PermisoController(IDataRepositorio<Permiso> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public PermisoController()
        {
        }

        [Route("all")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var permisos = await _dataRepository.GetAllAsync();
            return Ok(permisos);
        }


        [Route("update")]
        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Models.Permiso permiso)
        {
            if (permiso == null) return NotFound();
            var permisoDB = await _dataRepository.GetAsync(permiso.Id);
            if (permisoDB == null) return NotFound();
            await _dataRepository.UpdateAsync(permisoDB, permiso);
            return Ok();
        }

        [Route("new")]
        [HttpPost]
        public async Task<ActionResult> New([FromBody] Models.Permiso permiso)
        {
            permiso.TipoPermiso = null;
            if (permiso == null) return NotFound();
             await _dataRepository.AddAsync(permiso);
           
            return Ok();
        }

        [Route("delete")]
        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] Models.Permiso permiso)
        {
            if (permiso == null) return NotFound();
            var permisoDB = await _dataRepository.GetAsync(permiso.Id);
            if (permisoDB == null) return NotFound();
            await _dataRepository.DeleteAsync(permisoDB);

            return Ok();
        }


    }
}
