using ProvaEntity.Domain.Base;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Domain.Features.Resultados;
using System;
using System.Collections.Generic;

namespace ProvaEntity.Domain.Features.Alunos
{
    public class Aluno : Entidade
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Endereco Endereco { get; set; }
        public long EnderecoId { get; set; }

        public IList<Resultado> Resultados { get; set; }

        public override void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new AlunoNomeNuloOuVazioExcecao();
        }
    }
}
