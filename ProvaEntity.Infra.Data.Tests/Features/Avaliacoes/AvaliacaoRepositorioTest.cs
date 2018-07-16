using FluentAssertions;
using NUnit.Framework;
using ProvaEntity.Common.Tests.Base;
using ProvaEntity.Common.Tests.Features.Avaliacoes;
using ProvaEntity.Domain.Features.Avaliacoes;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Avaliacoes;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Tests.Features.Avaliacoes
{
    [TestFixture]
    public class AvaliacaoRepositorioTest
    {
        IAvaliacaoRepositorio _avaliacaoRepositorio;
        ProvaEntityDbContext _contexto;
        Avaliacao _avaliacaoPadrao;

        [SetUp]
        public void AvaliacaoRepositoryTestSetUp()
        {
            _contexto = new ProvaEntityDbContext();
            Database.SetInitializer(new DadosParaTeste());
            _contexto.Database.Initialize(true);

            _avaliacaoRepositorio = new AvaliacaoRepositorio(_contexto);

            _avaliacaoPadrao = AvaliacaoObjectMother.Padrao;
        }

        [Test]
        public void InfraData_Salvar_deve_incluir_um_novo_Avaliacao()
        {
            //Cenario
            long idEsperado = 2;

            //Acao
            var resultadoAvaliacao = _avaliacaoRepositorio.Salvar(_avaliacaoPadrao);

            //Verificar
            resultadoAvaliacao.Should().NotBeNull();
            resultadoAvaliacao.Id.Should().Be(idEsperado);
        }

        [Test]
        public void InfraData_Atualizar_deve_atualizar_um_avaliacao()
        {
            //Arrange
            var novoAvaliacao = _avaliacaoRepositorio.Salvar(_avaliacaoPadrao);
            novoAvaliacao.Data = DateTime.Now;

            //Action
            Action avaliacaoDB = () => _avaliacaoRepositorio.Atualizar(novoAvaliacao);

            //Assert
            avaliacaoDB.Should().NotBeNull();
            avaliacaoDB.Should().Equals(_avaliacaoPadrao.Data);
            var AvaliacaoContexto = _contexto.Avaliacoes.Find(novoAvaliacao.Id);
        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_avaliacao()
        {
            //Cenário
            int idPesquisa = 1;
            Avaliacao cliente = _avaliacaoRepositorio.ObterPorId(idPesquisa);

            //Ação
            _avaliacaoRepositorio.Deletar(cliente);

            //Verifica
            Avaliacao resultado = _avaliacaoRepositorio.ObterPorId(idPesquisa);
            resultado.Should().BeNull();
        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_avaliacaos()
        {
            //Cenário
            int tamanhoLista = 1;

            //Ação
            IList<Avaliacao> avaliacaos = _avaliacaoRepositorio.ObterTodos();

            //Verifica
            avaliacaos.Should().NotBeNull();
            avaliacaos.Count.Should().Be(tamanhoLista);
        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_avaliacao_por_id()
        {
            //Cenário
            int idPesquisa = 1;

            //Ação
            Avaliacao resultado = _avaliacaoRepositorio.ObterPorId(idPesquisa);

            //Verifica
            resultado.Should().NotBeNull();
            resultado.Id.Should().Be(idPesquisa);
        }
    }
}
