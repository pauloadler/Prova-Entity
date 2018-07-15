using ProvaEntity.Domain.Base;
using ProvaEntity.Domain.Features.Enderecos;
using System;

namespace ProvaEntity.Domain.Features.Alunos
{
    public class Aluno : Entidade
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public long EnderecoId { get; set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
