using System;
using System.Collections.Generic;
using ProvaEntity.Domain.Features.Alunos;

namespace ProvaEntity.Application.Features.Alunos
{
    public class AlunoServico : IAlunoServico
    {
        private IAlunoRepositorio _alunoRepository;

        public AlunoServico(IAlunoRepositorio alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public Aluno Salvar(Aluno entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Aluno entidade)
        {
            throw new NotImplementedException();
        }

        public Aluno ObterPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Deletar(Aluno entidade)
        {
            throw new NotImplementedException();
        }
    }
}
