using ProvaEntity.Domain.Base;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Domain.Features.Avaliacoes;

namespace ProvaEntity.Domain.Features.Resultados
{
    public class Resultado : Entidade
    {
        public double Nota { get; set; }

        public Aluno Aluno { get; set; }
        public long AlunoId { get; set; }

        public Avaliacao Avaliacao { get; set; }
        public long AvaliacaoId { get; set; }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
