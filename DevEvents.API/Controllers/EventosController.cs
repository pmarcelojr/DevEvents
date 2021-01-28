using System;
using DevEvents.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevEvents.API.Controllers
{
    // api/eventos
    [Route("api/eventos")]
    public class EventosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterEventos()
        {
            var evento = new Evento
            {
                Titulo = "Bootcamp ASPNET Core",
                Descricao = "Um super evento, para desenvolvedores",
                DataInicio = new DateTime(2021, 01, 25),
                DataFim = new DateTime(2021, 01, 29)
            };
            return Ok(evento);
        }
        // api/evento/ 1
        [HttpGet("{id}")]
        public IActionResult ObterEvento(int id)
        {
            return Ok();
        }

        // api/eventos
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Evento evento)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Evento evento)
        {
            return NoContent();
        }

        // api/eventos/{id}
        [HttpDelete("{id}")]
        public IActionResult Cancelar(int id)
        {
            return NoContent();
        }

        // api/eventos/1/usuarios/3/inscrever
        [HttpPost("{id}/usuarios/{idUsuario}/inscrever")]
        public IActionResult Inscrever(int id, int idUsuario, [FromBody] Inscricao inscricao)
        {
            return NoContent();
        }
    }
}