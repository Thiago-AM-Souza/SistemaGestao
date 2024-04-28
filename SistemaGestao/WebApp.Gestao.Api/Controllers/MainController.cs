using BuildingBlocks.Core.Handler;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Gestao.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        protected IMediatorHandler _mediatorHandler;

        protected MainController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        protected Guid UsuarioId { get; set; }
    }
}
