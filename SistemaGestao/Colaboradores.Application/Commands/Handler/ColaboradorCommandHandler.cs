using Colaboradores.Domain;
using MediatR;

namespace Colaboradores.Application.Commands.Handler
{
    public class ColaboradorCommandHandler : IRequestHandler<CadastrarColaboradorCommand, bool>,
                                             IRequestHandler<AtualizarColaboradorCommand, bool>,
                                             IRequestHandler<RemoverColaboradorCommand, bool>
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorCommandHandler(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public async Task<bool> Handle(CadastrarColaboradorCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var usuario = await _colaboradorRepository.ObterUsuarioPorId(command.UsuarioId);

                if (usuario == null)
                {
                    return false;
                }

                var unidade = await _colaboradorRepository.ObterUnidadePorId(command.UnidadeId);

                if (unidade == null || unidade.Desativado)
                {
                    return false;
                }

                var colaborador = new Colaborador(command.Nome,
                                                  usuario,
                                                  unidade);

                await _colaboradorRepository.CadastrarColaborador(colaborador);

                await _colaboradorRepository.SaveChanges.Commit();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Handle(AtualizarColaboradorCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var colaborador = await _colaboradorRepository.ObterColaboradorPorId(command.Id);

                if (colaborador == null)
                {
                    return false;
                }

                var unidade = await _colaboradorRepository.ObterUnidadePorId(command.UnidadeId);

                if (unidade == null || unidade.Desativado)
                {
                    return false;
                }

                colaborador.Alterar(command.Nome,
                                    unidade);

                _colaboradorRepository.AtualizarColaborador(colaborador);

                await _colaboradorRepository.SaveChanges.Commit();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Handle(RemoverColaboradorCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var colaborador = await _colaboradorRepository.ObterColaboradorPorId(command.Id);

                if (colaborador == null)
                {
                    return false;
                }

                _colaboradorRepository.RemoverColaborador(colaborador);

                await _colaboradorRepository.SaveChanges.Commit(); 
            
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
