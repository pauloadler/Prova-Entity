using System.Collections.Generic;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Infra.Data.Contexts;

namespace ProvaEntity.Infra.Data.Features.Alunos
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private ProvaEntityDbContext _contexto;

        public AlunoRepositorio(ProvaEntityDbContext contexto)
        {
            _contexto = contexto;
        }

        public Aluno Salvar(Aluno aluno)
        {
            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            return aluno;
        }

        public Aluno ObterPorId(long id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Aluno> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(Aluno entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(Aluno entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}
