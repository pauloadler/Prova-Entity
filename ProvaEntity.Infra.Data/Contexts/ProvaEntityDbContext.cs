using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Infra.Data.Features.Alunos;
using ProvaEntity.Infra.Data.Features.Enderecos;
using System.Configuration;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Contexts
{
    public class ProvaEntityDbContext : DbContext
    {
        public ProvaEntityDbContext(string connection = "ProvaEntity") : base(connection)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoEntityConfiguracao());
            modelBuilder.Configurations.Add(new EnderecoEntityConfiguracao());
        }
    }
}
