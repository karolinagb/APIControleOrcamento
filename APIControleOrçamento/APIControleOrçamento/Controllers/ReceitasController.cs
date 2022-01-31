using APIControleOrçamento.Models;
using APIControleOrçamento.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace APIControleOrçamento.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private readonly ReceitaRepository _receitaRepository;

        public ReceitasController(ReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Receita model)
        {
            try
            {
                _receitaRepository.Add(model);

                return Ok();

                //return new CreatedAtRouteResult("ObterReceita", new { id = model.Id }, model);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar criar uma nova receita");
            }
        }
    }
}
