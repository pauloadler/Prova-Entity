using ProvaEntity.Domain.Features.Avaliacoes;
using System;
using System.Collections.Generic;

namespace ProvaEntity.Common.Tests.Features.Avaliacoes
{
    public class AvaliacaoObjectMother
    {
        public static Avaliacao Padrao
        {
            get
            {
                return new Avaliacao()
                {
                    Data = DateTime.Now.AddDays(-2)
                };
            }
        }

        public static Avaliacao PadraoComId
        {
            get
            {
                return new Avaliacao()
                {
                    Id = 1,
                    Data = DateTime.Now.AddDays(-2)
                };
            }
        }

        public static IList<Avaliacao> ListaPadraoAvaliacaos
        {
            get
            {
                IList<Avaliacao> allAvaliacaos = new List<Avaliacao>();

                allAvaliacaos.Add(new Avaliacao()
                {
                    Id = 2,
                    Data = DateTime.Now.AddDays(-3)
                });

                allAvaliacaos.Add(new Avaliacao()
                {
                    Id = 3,
                    Data = DateTime.Now.AddDays(-3)
                });

                allAvaliacaos.Add(new Avaliacao()
                {
                    Id = 4,
                    Data = DateTime.Now.AddDays(-3)
                });

                return allAvaliacaos;
            }
        }
    }
}
