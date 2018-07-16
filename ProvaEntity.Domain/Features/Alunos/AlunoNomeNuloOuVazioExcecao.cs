using ProvaEntity.Domain.Base;

namespace ProvaEntity.Domain.Features.Alunos
{
    public class AlunoNomeNuloOuVazioExcecao : ExcessaoNegocio
    {
        public AlunoNomeNuloOuVazioExcecao() : base("O nome não pode ser nulo ou vazio!")
        {
        }
    }
}