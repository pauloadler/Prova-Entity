using FluentAssertions;
using NUnit.Framework;
using ProvaEntity.Common.Tests.Base;
using ProvaEntity.Common.Tests.Features.Alunos;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Alunos;
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

        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_aluno()
        {

        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_alunos()
        {

        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_aluno_por_id()
        {

        }
    }
}
