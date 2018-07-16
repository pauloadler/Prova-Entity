using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            return _contexto.Alunos.Where(c => c.Id == id).FirstOrDefault();
        }

        public IList<Aluno> ObterTodos()
        {
            return _contexto.Alunos.ToList();
        }

        public void Atualizar(Aluno aluno)
        {
            _contexto.Entry(aluno).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Deletar(Aluno aluno)
        {
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
        }
    }
}
