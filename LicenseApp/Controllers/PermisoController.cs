using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LicenseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : ControllerBase
    {
        private readonly IPermisoService _service;
        private readonly ITipoPermisoService _tipoPermisoService;

        public PermisoController(IPermisoService service, ITipoPermisoService tipoPermisoService)
        {
            _service = service;
            _tipoPermisoService = tipoPermisoService;
        }

        [HttpGet("[action]")]
        public IActionResult Get()
        {
            return Ok(
                new
                {
                    Data = _service.Get(),
                    Tipos = _tipoPermisoService.Get()
                }
            );
        }

        [HttpPost("[action]")]
        public IActionResult Add(PermisoModel model)
        {
            return Ok(_service.Add(model));
        }

        [HttpPut("[action]")]
        public IActionResult Update(PermisoModel model)
        {
            return Ok(_service.Update(model));
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }
    }
}