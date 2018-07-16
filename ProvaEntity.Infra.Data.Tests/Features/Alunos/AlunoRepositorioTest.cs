using FluentAssertions;
using NUnit.Framework;
using ProvaEntity.Common.Tests.Base;
using ProvaEntity.Common.Tests.Features.Alunos;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Alunos;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Tests.Features.Alunos
{
    [TestFixture]
    public class AlunoRepositorioTest
    {
        IAlunoRepositorio _alunoRepositorio;
        ProvaEntityDbContext _contexto;
        Aluno _alunoPadrao;

        [SetUp]
        public void AlunoRepositoryTestSetUp()
        {
            _contexto = new ProvaEntityDbContext();
            Database.SetInitializer(new DadosParaTeste());
            _contexto.Database.Initialize(true);

            _alunoRepositorio = new AlunoRepositorio(_contexto);

            _alunoPadrao = AlunoObjectMother.Padrao;
        }

        [Test]
        public void InfraData_Salvar_deve_incluir_um_novo_Aluno()
        {
            //Cenario
            long idEsperado = 2;

            //Acao
            var resultadoAluno = _alunoRepositorio.Salvar(_alunoPadrao);

            //Verificar
            resultadoAluno.Should().NotBeNull();
            resultadoAluno.Id.Should().Be(idEsperado);
        }

        [Test]
        public void InfraData_Atualizar_deve_atualizar_um_aluno()
        {
            //Arrange
            var novoAluno = _alunoRepositorio.Salvar(_alunoPadrao);
            novoAluno.Nome = "Nome Atualizado";

            //Action
            Action alunoDB = () => _alunoRepositorio.Atualizar(novoAluno);

            //Assert
            alunoDB.Should().NotBeNull();
            alunoDB.Should().Equals(_alunoPadrao.Nome);
            var AlunoContexto = _contexto.Alunos.Find(novoAluno.Id);
        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_aluno()
        {
            //Cenário
            int idPesquisa = 1;
            Aluno cliente = _alunoRepositorio.ObterPorId(idPesquisa);

            //Ação
            _alunoRepositorio.Deletar(cliente);

            //Verifica
            Aluno resultado = _alunoRepositorio.ObterPorId(idPesquisa);
            resultado.Should().BeNull();
        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_alunos()
        {
            //Cenário
            int tamanhoLista = 1;

            //Ação
            IList<Aluno> alunos = _alunoRepositorio.ObterTodos();

            //Verifica
            alunos.Should().NotBeNull();
            alunos.Count.Should().Be(tamanhoLista);
        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_aluno_por_id()
        {
            //Cenário
            int idPesquisa = 1;

            //Ação
            Aluno resultado = _alunoRepositorio.ObterPorId(idPesquisa);

            //Verifica
            resultado.Should().NotBeNull();
            resultado.Id.Should().Be(idPesquisa);
        }
    }
}
