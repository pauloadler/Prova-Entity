using System.Collections.Generic;
using ProvaEntity.Domain.Features.Avaliacoes;
using ProvaEntity.Infra.Data.Contexts;

namespace ProvaEntity.Infra.Data.Features.Avaliacoes
{
    public class AvaliacaoRepositorio : IAvaliacaoRepositorio
    {
        private ProvaEntityDbContext _contexto;

        public AvaliacaoRepositorio(ProvaEntityDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Atualizar(Avaliacao entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(Avaliacao entidade)
        {
            throw new System.NotImplementedException();
        }

        public Avaliacao ObterPorId(long id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Avaliacao> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public Avaliacao Salvar(Avaliacao entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}
