using BuildingBlocks.Core.Handler;
using Colaboradores.Application.Commands;
using Colaboradores.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using WebApp.Gestao.Api.Controllers.Colaboradores.InputModels;

namespace WebApp.Gestao.Api.Controllers.Colaboradores
{
    [ApiExplorerSettings(GroupName = "Colaboradores")]
    [Route("api/colaboradores")]
    public class ColaboradoresController : MainController
    {
        private readonly IColaboradorQueries _colaboradorQueries;
        public ColaboradoresController(IMediatorHandler mediatorHandler,
                                       IColaboradorQueries colaboradorQueries) : base(mediatorHandler)
        {
            _colaboradorQueries = colaboradorQueries;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(ColaboradorInputModel inputModel)
        {
            var command = new CadastrarColaboradorCommand(inputModel.Nome,
                                                          inputModel.UnidadeId, 
                                                          inputModel.UsuarioId);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Created("Colaboradores", "Colaborador cadastrado com sucesso.");
            else
                return BadRequest("Erro ao Cadastrar colaborador");
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var command = new RemoverColaboradorCommand(id);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Remover colaborador");
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var response = await _colaboradorQueries.ObterTodosColaboradores();

            if (response.Count() > 0)
                return Ok(response);
            else
                return NoContent();
        }
    }
}
