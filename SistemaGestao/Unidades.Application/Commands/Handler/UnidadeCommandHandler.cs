using BuildingBlocks.Core.Handler;
using MediatR;
using Unidades.Domain;

namespace Unidades.Application.Commands.Handler
{
    public class UnidadeCommandHandler : IRequestHandler<CadastrarUnidadeCommand, bool>,
                                         IRequestHandler<AtivarUnidadeCommand, bool>,
                                         IRequestHandler<DesativarUnidadeCommand, bool>
    {
        private readonly IUnidadeRepository _unidadeRepository;

        public UnidadeCommandHandler(IUnidadeRepository unidadeRepository) 
        { 
            _unidadeRepository = unidadeRepository;
        }
        public async Task<bool> Handle(CadastrarUnidadeCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var unidade = await _unidadeRepository.ObterUnidadePorCodigo(command.Codigo);

                if (unidade != null) 
                {
                    return false;
                }

                unidade = new Unidade(command.Codigo,
                                      command.Nome);

                await _unidadeRepository.CadastrarUnidade(unidade);

                await _unidadeRepository.SaveChanges.Commit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Handle(AtivarUnidadeCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var unidade = await _unidadeRepository.ObterUnidadePorId(command.Id);

                if (unidade == null)
                {
                    return false;
                }

                unidade.AtivarUnidade();

                _unidadeRepository.AtualizarUnidade(unidade);

                await _unidadeRepository.SaveChanges.Commit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Handle(DesativarUnidadeCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var unidade = await _unidadeRepository.ObterUnidadePorId(command.Id);

                if (unidade == null)
                {
                    return false;
                }

                unidade.DesativarUnidade();

                _unidadeRepository.AtualizarUnidade(unidade);

                await _unidadeRepository.SaveChanges.Commit();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
