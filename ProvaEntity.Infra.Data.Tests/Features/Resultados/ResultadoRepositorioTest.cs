using FluentAssertions;
using NUnit.Framework;
using ProvaEntity.Common.Tests.Base;
using ProvaEntity.Common.Tests.Features.Resultados;
using ProvaEntity.Domain.Features.Resultados;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Resultados;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Tests.Features.Resultados
{
    [TestFixture]
    public class ResultadoRepositorioTest
    {

        IResultadoRepositorio _resultadoRepositorio;
        ProvaEntityDbContext _contexto;
        Resultado _resultadoPadrao;

        [SetUp]
        public void ResultadoRepositoryTestSetUp()
        {
            _contexto = new ProvaEntityDbContext();
            Database.SetInitializer(new DadosParaTeste());
            _contexto.Database.Initialize(true);

            _resultadoRepositorio = new ResultadoRepositorio(_contexto);

            _resultadoPadrao = ResultadoObjectMother.Padrao;
        }

        [Test]
        public void InfraData_Salvar_deve_incluir_um_novo_Resultado()
        {
            //Cenario
            long idEsperado = 2;

            //Acao
            var resultadoResultado = _resultadoRepositorio.Salvar(_resultadoPadrao);

            //Verificar
            resultadoResultado.Should().NotBeNull();
            resultadoResultado.Id.Should().Be(idEsperado);
        }

        [Test]
        public void InfraData_Atualizar_deve_atualizar_um_resultado()
        {
            //Arrange
            var novoResultado = _resultadoRepositorio.Salvar(_resultadoPadrao);
            novoResultado.Nota = 7.5;

            //Action
            Action resultadoDB = () => _resultadoRepositorio.Atualizar(novoResultado);

            //Assert
            resultadoDB.Should().NotBeNull();
            resultadoDB.Should().Equals(_resultadoPadrao.Nota);
            var ResultadoContexto = _contexto.Resultados.Find(novoResultado.Id);
        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_resultado()
        {
            //Cenário
            int idPesquisa = 1;
            Resultado cliente = _resultadoRepositorio.ObterPorId(idPesquisa);

            //Ação
            _resultadoRepositorio.Deletar(cliente);

            //Verifica
            Resultado resultado = _resultadoRepositorio.ObterPorId(idPesquisa);
            resultado.Should().BeNull();
        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_resultados()
        {
            //Cenário
            int tamanhoLista = 1;

            //Ação
            IList<Resultado> resultados = _resultadoRepositorio.ObterTodos();

            //Verifica
            resultados.Should().NotBeNull();
            resultados.Count.Should().Be(tamanhoLista);
        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_resultado_por_id()
        {
            //Cenário
            int idPesquisa = 1;

            //Ação
            Resultado resultado = _resultadoRepositorio.ObterPorId(idPesquisa);

            //Verifica
            resultado.Should().NotBeNull();
            resultado.Id.Should().Be(idPesquisa);
        }

        [Test]
        public void InfraData_BuscarResultadoPorAlunoId_deve_buscar_os_resultados_pelo_id_do_aluno()
        {
            //Cenário
            int quantidadeResultados = 1;
            long alunoId = 2;
            //_resultadoRepositorio.Salvar(_resultadoPadrao);

            //Acao
            var resultadosAluno = _resultadoRepositorio.BuscarResultadosPorAlunoId(alunoId);

            //Verifica
            resultadosAluno.Should().HaveCount(quantidadeResultados);
        }
    }
}
