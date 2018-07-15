
using ProvaEntity.Domain.Features.Enderecos;
using System.Collections.Generic;

namespace ProvaEntity.Common.Tests.Features.Enderecos
{
    public class EnderecoObjectMother
    {
        public static Endereco Padrao
        {
            get
            {
                return new Endereco()
                {
                    Bairro = "Cepar",
                    Logradouro = "Rua Jardim"
                };
            }
        }

        public static Endereco PadraoComId
        {
            get
            {
                return new Endereco()
                {
                    Id = 1,
                    Bairro = "Centro",
                    Logradouro = "Rua Aristoteles"
                };
            }
        }

        public static IList<Endereco> ListaPadraoEnderecos
        {
            get
            {
                IList<Endereco> allEnderecos = new List<Endereco>();

                allEnderecos.Add(new Endereco()
                {
                    Id = 2,
                    Bairro = "Centro",
                    Logradouro = "Rua José"
                });

                allEnderecos.Add(new Endereco()
                {
                    Id = 3,
                    Bairro = "Guarujá",
                    Logradouro = "Rua Minerva"
                });

                allEnderecos.Add(new Endereco()
                {
                    Id = 4,
                    Bairro = "Coral",
                    Logradouro = "Rua José Craudio"
                });

                return allEnderecos;
            }
        }
    }
}
