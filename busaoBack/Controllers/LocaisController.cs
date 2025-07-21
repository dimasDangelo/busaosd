using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace busaoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocaisController : ControllerBase
    {
        private readonly ILocalService _localService;
        public LocaisController(ILocalService localService)
        {
            _localService = localService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var locais = _localService.getAll();
            return Ok(locais);
        }
        [HttpPost]
        public IActionResult Add([FromBody] Domain.Locais local)
        {
            if (local == null || string.IsNullOrEmpty(local.nome) || local.id_tipo_local <= 0)
            {
                return BadRequest("Local cannot be null and must have a valid name and type ID.");
            }
            _localService.add(local);
            return Ok();
        }
        [HttpPatch]
        public IActionResult Update([FromBody] Domain.Locais local)
        {
            if (local == null || int.Parse(local.id)  <= 0 || string.IsNullOrEmpty(local.nome) || local.id_tipo_local <= 0)
            {
                return BadRequest("Local must have a valid ID, name, and type ID.");
            }
            _localService.update(local);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("ID cannot be null or empty.");
            }
            _localService.remove(id);
            return Ok();
        }
    }
}
