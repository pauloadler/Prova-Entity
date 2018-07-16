using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Domain.Features.Avaliacoes;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Domain.Features.Resultados;
using ProvaEntity.Infra.Data.Features.Alunos;
using ProvaEntity.Infra.Data.Features.Avaliacoes;
using ProvaEntity.Infra.Data.Features.Enderecos;
using ProvaEntity.Infra.Data.Features.Resultados;
using System.Configuration;
using System.Data.Entity;

namespace ProvaEntity.Infra.Data.Contexts
{
    public class ProvaEntityDbContext : DbContext
    {
        public ProvaEntityDbContext() : base(ConfigurationManager.AppSettings.Get("ConnectionStringProvaEntity"))
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Resultado> Resultados { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoEntityConfiguracao());
            modelBuilder.Configurations.Add(new EnderecoEntityConfiguracao());
            modelBuilder.Configurations.Add(new AvaliacaoEntityConfiguracao());
            modelBuilder.Configurations.Add(new ResultadoEntityConfiguracao());
        }
    }
}
