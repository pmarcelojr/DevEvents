using System.Collections.Generic;
using DevEvents.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevEvents.API.Controllers
{
    [Route("api/categorias")]
    public class CategoriasController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodas()
        {
            var categorias = new List<Categoria>
            {
                new Categoria { Descricao = ".NET" },
                new Categoria { Descricao = "Desenvolvimento Mobile" },
                new Categoria { Descricao = "Machine Learning" },
            };
            
            return Ok(categorias);
        }
    }
}