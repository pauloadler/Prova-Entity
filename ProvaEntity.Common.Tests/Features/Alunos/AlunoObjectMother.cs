using ProvaEntity.Common.Tests.Features.Enderecos;
using ProvaEntity.Domain.Features.Alunos;
using System;
using System.Collections.Generic;

namespace ProvaEntity.Common.Tests.Features.Alunos
{
    public class AlunoObjectMother
    {
        public static Aluno Padrao
        {
            get
            {
                return new Aluno()
                {
                    Nome = "José Pedro",
                    Idade = 17,
                    Endereco = EnderecoObjectMother.PadraoComId
                };
            }
        }

        public static Aluno PadraoComId
        {
            get
            {
                return new Aluno()
                {
                    Id = 1,
                    Nome = "Aluizio Aristides",
                    Idade = 17,
                    Endereco = EnderecoObjectMother.PadraoComId
                };
            }
        }

        public static IList<Aluno> ListaPadraoAlunos
        {
            get
            {
                IList<Aluno> allAlunos = new List<Aluno>();

                allAlunos.Add(new Aluno()
                {
                    Id = 2,
                    Nome = "João Craudio",
                    Idade = 15,
                    Endereco = EnderecoObjectMother.PadraoComId
                });

                allAlunos.Add(new Aluno()
                {
                    Id = 3,
                    Nome = "MInerva de Custodia",
                    Idade = 17,
                    Endereco = EnderecoObjectMother.PadraoComId
                });

                allAlunos.Add(new Aluno()
                {
                    Id = 4,
                    Nome = "Merive Aristides",
                    Idade = 16,
                    Endereco = EnderecoObjectMother.PadraoComId
                });

                return allAlunos;
            }
        }
    }
}
