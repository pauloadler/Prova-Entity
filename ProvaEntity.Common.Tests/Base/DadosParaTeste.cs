using ProvaEntity.Common.Tests.Features.Alunos;
using ProvaEntity.Common.Tests.Features.Enderecos;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Infra.Data.Contexts;
using System.Data.Entity;

namespace ProvaEntity.Common.Tests.Base
{
    public class DadosParaTeste : DropCreateDatabaseAlways<ProvaEntityDbContext>
    {
        protected override void Seed(ProvaEntityDbContext contexto)
        {
            Aluno aluno = AlunoObjectMother.Padrao;
            Endereco endereco = EnderecoObjectMother.Padrao;

            contexto.Alunos.Add(aluno);
            contexto.Enderecos.Add(endereco);

            contexto.SaveChanges();

            base.Seed(contexto);
        }

    }
}
