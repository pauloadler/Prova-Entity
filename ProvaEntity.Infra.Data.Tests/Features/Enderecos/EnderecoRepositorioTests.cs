using FluentAssertions;
using NUnit.Framework;
using ProvaEntity.Common.Tests.Base;
using ProvaEntity.Common.Tests.Features.Enderecos;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Tests.Features.Enderecos
{
    [TestFixture]
    public class EnderecoRepositorioTest
    {
        IEnderecoRepositorio _enderecoRepositorio;
        ProvaEntityDbContext _contexto;
        Endereco _enderecoPadrao;

        [SetUp]
        public void EnderecoRepositoryTestSetUp()
        {
            _contexto = new ProvaEntityDbContext();
            Database.SetInitializer(new DadosParaTeste());
            _contexto.Database.Initialize(true);

            _enderecoRepositorio = new EnderecoRepositorio(_contexto);

            _enderecoPadrao = EnderecoObjectMother.Padrao;
        }

        [Test]
        public void InfraData_Salvar_deve_incluir_um_novo_Endereco()
        {
            //Cenario
            long idEsperado = 3;

            //Acao
            var resultadoEndereco = _enderecoRepositorio.Salvar(_enderecoPadrao);

            //Verificar
            resultadoEndereco.Should().NotBeNull();
            resultadoEndereco.Id.Should().Be(idEsperado);
        }

        [Test]
        public void InfraData_Atualizar_deve_atualizar_um_endereco()
        {
            //Arrange
            var novoEndereco = _enderecoRepositorio.Salvar(_enderecoPadrao);
            novoEndereco.Bairro = "bairro Atualizado";

            //Action
            Action enderecoDB = () => _enderecoRepositorio.Atualizar(novoEndereco);

            //Assert
            enderecoDB.Should().NotBeNull();
            enderecoDB.Should().Equals(_enderecoPadrao.Bairro);
            var EnderecoContexto = _contexto.Enderecos.Find(novoEndereco.Id);
        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_endereco()
        {
            //Cenário
            int idPesquisa = 1;
            Endereco cliente = _enderecoRepositorio.ObterPorId(idPesquisa);

            //Ação
            _enderecoRepositorio.Deletar(cliente);

            //Verifica
            Endereco resultado = _enderecoRepositorio.ObterPorId(idPesquisa);
            resultado.Should().BeNull();
        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_enderecos()
        {
            //Cenário
            int tamanhoLista = 2;

            //Ação
            IList<Endereco> enderecos = _enderecoRepositorio.ObterTodos();

            //Verifica
            enderecos.Should().NotBeNull();
            enderecos.Count.Should().Be(tamanhoLista);
        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_endereco_por_id()
        {
            //Cenário
            int idPesquisa = 1;

            //Ação
            Endereco resultado = _enderecoRepositorio.ObterPorId(idPesquisa);

            //Verifica
            resultado.Should().NotBeNull();
            resultado.Id.Should().Be(idPesquisa);
        }
    }
}
