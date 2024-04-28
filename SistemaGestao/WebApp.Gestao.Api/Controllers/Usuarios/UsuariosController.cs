using BuildingBlocks.Core.Handler;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using Usuarios.Application.Commands;
using Usuarios.Application.Queries;
using WebApp.Gestao.Api.Controllers.Usuarios.InputModels;

namespace WebApp.Gestao.Api.Controllers.Usuarios
{
    public class UsuariosController : MainController
    {
        private readonly IUsuarioQueries _usuarioQueries;
        public UsuariosController(IMediatorHandler mediatorHandler,
                                  IUsuarioQueries usuarioQueries) : base(mediatorHandler)
        {
            _usuarioQueries = usuarioQueries;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(CadastrarUsuarioInputModel cadastrarUsuario)
        {
            var command = new CadastrarUsuarioCommand(cadastrarUsuario.Login,
                                                      cadastrarUsuario.Senha);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Created();
            else
                return BadRequest("Erro ao Cadastrar usuário.");
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Put(AtualizarUsuarioInputModel inputModel)
        {
            var command = new AtualizarUsuarioCommand(inputModel.Id,
                                                      inputModel.Senha);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Atualizar usuário.");
        }

        [HttpPatch("desativar/{id:guid}")]
        public async Task<IActionResult> PatchDesativar(Guid id)
        {
            var command = new DesativarUsuarioCommand(id);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Desativar usuário.");
        }

        [HttpPatch("ativar/{id:guid}")]
        public async Task<IActionResult> PatchAtivar(Guid id)
        {
            var command = new AtivarUsuarioCommand(id);

            var success = await _mediatorHandler.SendCommand(command);

            if (success)
                return Ok();
            else
                return BadRequest("Erro ao Ativar usuário.");
        }

        [HttpGet("")]
        public async Task<IActionResult> Get(bool? desativado)
        {
            var response = await _usuarioQueries.ObterTodosUsuarios(desativado);

            if (response.Count() > 0)
                return Ok(response);
            else 
                return NoContent();
        }
    }
}
