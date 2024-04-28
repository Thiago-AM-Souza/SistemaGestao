using BuildingBlocks.Core.Handler;
using Microsoft.AspNetCore.Mvc;
using Unidades.Application.Commands;
using Unidades.Application.Queries;
using WebApp.Gestao.Api.Controllers.Unidades.InputModels;

namespace WebApp.Gestao.Api.Controllers.Unidades
{
    public class UnidadesController : MainController
    {
        private readonly IUnidadeQueries _unidadeQueries;
        public UnidadesController(IMediatorHandler mediatorHandler,
                                  IUnidadeQueries unidadeQueries) : base(mediatorHandler)
        {
            _unidadeQueries = unidadeQueries;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(CadastrarUnidadeInputModel cadastrarUnidade)
        {
            var command = new CadastrarUnidadeCommand(cadastrarUnidade.Codigo,
                                                      cadastrarUnidade.Nome);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Created();
            else
                return BadRequest("Erro ao cadastrar usuário.");
        }

        [HttpPatch("desativar/{id:guid}")]
        public async Task<IActionResult> PatchDesativar(Guid id)
        {
            var command = new DesativarUnidadeCommand(id);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Desativar unidade.");
        }

        [HttpPatch("ativar/{id:guid}")]
        public async Task<IActionResult> PatchAtivar(Guid id)
        {
            var command = new AtivarUnidadeCommand(id);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Desativar usuário.");
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var response = await _unidadeQueries.ObterTodasUnidades();

            if (response.Count() > 0)
                return Ok(response);
            else
                return NoContent();
        }
    }
}
