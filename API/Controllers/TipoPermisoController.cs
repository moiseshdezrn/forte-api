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
    public class TipoPermisoController : ControllerBase
    {

        private readonly IDataRepositorio<TipoPermiso> _dataRepository;
        public TipoPermisoController(IDataRepositorio<TipoPermiso> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        [Route("all")]
        public async Task<ActionResult> GetAll()
        {
            var tiposPermiso = await _dataRepository.GetAllAsync();
            return Ok(tiposPermiso);
        }
    }
}
