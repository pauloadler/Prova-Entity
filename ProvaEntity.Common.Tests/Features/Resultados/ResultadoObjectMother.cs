using ProvaEntity.Common.Tests.Features.Alunos;
using ProvaEntity.Common.Tests.Features.Avaliacoes;
using ProvaEntity.Domain.Features.Resultados;
using System.Collections.Generic;

namespace ProvaEntity.Common.Tests.Features.Resultados
{
    public class ResultadoObjectMother
    {
        public static Resultado Padrao
        {
            get
            {
                return new Resultado()
                {
                    Nota = 5,
                    Aluno = AlunoObjectMother.PadraoComId,
                    Avaliacao = AvaliacaoObjectMother.PadraoComId
                };
            }
        }

        public static Resultado PadraoComId
        {
            get
            {
                return new Resultado()
                {
                    Id = 1,
                    Nota = 7,
                    Aluno = AlunoObjectMother.PadraoComId,
                    Avaliacao = AvaliacaoObjectMother.PadraoComId
                };
            }
        }

        public static IList<Resultado> ListaPadraoResultados
        {
            get
            {
                IList<Resultado> allResultados = new List<Resultado>();

                allResultados.Add(new Resultado()
                {
                    Id = 2,
                    Nota = 6,
                    Aluno = AlunoObjectMother.PadraoComId,
                    Avaliacao = AvaliacaoObjectMother.PadraoComId
                });

                allResultados.Add(new Resultado()
                {
                    Id = 3,
                    Nota = 7,
                    Aluno = AlunoObjectMother.PadraoComId,
                    Avaliacao = AvaliacaoObjectMother.PadraoComId
                });

                allResultados.Add(new Resultado()
                {
                    Id = 4,
                    Nota = 8,
                    Aluno = AlunoObjectMother.PadraoComId,
                    Avaliacao = AvaliacaoObjectMother.PadraoComId
                });

                return allResultados;
            }
        }
    }
}
