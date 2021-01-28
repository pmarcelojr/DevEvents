using DevEvents.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevEvents.API.Controllers
{
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            return Ok();
        }
    }
}