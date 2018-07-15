using NUnit.Framework;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Infra.Data.Contexts;
using ProvaEntity.Infra.Data.Features.Enderecos;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Tests.Features.Enderecos
{
    [TestFixture]
    public class EnderecoRepositorioTests
    {
        IEnderecoRepositorio _EnderecoRepositorio;
        ProvaEntityDbContext _contexto;

        [SetUp]
        public void EnderecoRepositorioTestSetUp()
        {
            _EnderecoRepositorio = new EnderecoRepositorio();

            _contexto = new ProvaEntityDbContext();
            Database.SetInitializer(new DropCreateDatabaseAlways<ProvaEntityDbContext>());
            _contexto.Database.Initialize(true);
        }

        [Test]
        public void InfraData_Salvar_deve_salvar_os_enderecos()
        {

        }

        [Test]
        public void InfraData_Atualizar_deve_atualizar_um_endereco()
        {

        }

        [Test]
        public void InfraData_Deletar_deve_deletar_um_endereco()
        {

        }

        [Test]
        public void InfraData_ObterTodos_deve_buscar_todos_os_enderecos()
        {

        }

        [Test]
        public void InfraData_ObterPorId_deve_buscar_um_endereco_por_id()
        {

        }
    }
}
