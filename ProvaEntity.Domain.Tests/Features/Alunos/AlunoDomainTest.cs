using ProvaEntity.Domain.Features.Alunos;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace ProvaEntity.Domain.Tests.Features.Alunos
{
    [TestFixture]
    public class AlunoDomainTest
    {
        //Aluno _AlunoDefault;

        [SetUp]
        public void AlunoDomainTestSetUp()
        {
            //_AlunoDefault = AlunoObjectMother.Default;
        }

        [Test]
        public void Dominio_Aluno_nao_deve_possuir_livro_sem_disponibilidade()
        {
            //Arrange

            //Action

            //Assert
        }

        [Test]
        public void Dominio_Aluno_deve_calcular_a_multa_de_atraso_quando_Aluno_ja_tiver_sido_cadastrado()
        {
            //Arrange

            //Action

            //Assert
        }
        
        [Test]
        public void Dominio_Aluno_nao_deve_calcular_a_multa_de_atraso_quando_Aluno_nao_tiver_sido_cadastrado()
        {
            //Arrange

            //Action

            //Assert
        }

        [Test]
        public void Dominio_Aluno_nao_deve_ter_cliente_vazio()
        {
            //Arrange

            //Action

            //Assert
        }

        [Test]
        public void Dominio_Aluno_deve_possuir_todos_os_dados_quando_estiverem_corretors_e_validados()
        {
            //Action-Arrange
            
            //Assert
        }
    }
}
