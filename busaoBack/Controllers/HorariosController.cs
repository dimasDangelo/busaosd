using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace busaoBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HorariosController : ControllerBase
    {
       private readonly IHorarioService _horarioService;
        public HorariosController(IHorarioService horario)
        {
            _horarioService = horario;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var horarios = _horarioService.GetAll();
            return Ok(horarios);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Horarios_onibus horarios)
        {
            if (horarios == null)
            {
                return BadRequest("Horarios cannot be null");
            }
            _horarioService.add(horarios);
            return CreatedAtAction(nameof(GetAll), new { id = horarios.Id }, horarios);
        }
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Horarios_onibus horarios)
        {
            if (horarios == null || horarios.Id != id)
            {
                return BadRequest("Horarios cannot be null or ID mismatch");
            }
            _horarioService.update(horarios);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("ID cannot be null or empty");
            }
            _horarioService.delete(id);
            return NoContent();
        }
    }
}
