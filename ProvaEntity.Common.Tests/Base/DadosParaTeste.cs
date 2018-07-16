using ProvaEntity.Common.Tests.Features.Resultados;
using ProvaEntity.Domain.Features.Resultados;
using ProvaEntity.Infra.Data.Contexts;
using System.Data.Entity;

namespace ProvaEntity.Common.Tests.Base
{
    public class DadosParaTeste : DropCreateDatabaseAlways<ProvaEntityDbContext>
    {
        protected override void Seed(ProvaEntityDbContext contexto)
        {
           
            Resultado resultado = ResultadoObjectMother.Padrao;
            
            contexto.Resultados.Add(resultado);

            contexto.SaveChanges();

            base.Seed(contexto);
        }
    }
}
