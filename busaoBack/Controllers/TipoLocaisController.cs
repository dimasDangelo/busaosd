using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace busaoBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoLocaisController : ControllerBase
    {
        private readonly ITipo_LocalService _LocalService;
        public TipoLocaisController(ITipo_LocalService localTipo)
        {
            _LocalService = localTipo;
        }
        [HttpGet]
        public IActionResult Get() => Ok(_LocalService.GetAll());

        [HttpPost]
        public IActionResult Add([FromBody] string nome)
        {

            if (string.IsNullOrEmpty(nome))
            {
                return BadRequest("Nome cannot be null or empty.");
            }
            _LocalService.Add(nome);
            return Ok();
        }
        [HttpPatch]
        public IActionResult Update([FromBody] string nome, string id)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return BadRequest("Nome cannot be null or empty.");
            }
            _LocalService.Update(nome, id);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("ID cannot be null or empty.");
            }     
             _LocalService.Remove(id);
            return Ok();
        }
    }
}
