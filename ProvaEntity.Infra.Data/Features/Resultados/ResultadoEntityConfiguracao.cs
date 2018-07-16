using ProvaEntity.Domain.Features.Resultados;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProvaEntity.Infra.Data.Features.Resultados
{
    class ResultadoEntityConfiguracao : EntityTypeConfiguration<Resultado>
    {
        public ResultadoEntityConfiguracao()
        {
            ToTable("TBResultado");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Nota).HasColumnName("nota").IsRequired();

            this.Property(a => a.AlunoId).HasColumnName("aluno_id").IsRequired();
            this.HasRequired(a => a.Aluno).WithMany().HasForeignKey(a => a.AlunoId);
            this.HasRequired(a => a.Aluno).WithMany(x => x.Resultados).HasForeignKey(x => x.AlunoId);

            this.Property(a => a.AvaliacaoId).HasColumnName("avaliacao_id").IsRequired();
            this.HasRequired(a => a.Avaliacao).WithMany().HasForeignKey(a => a.AvaliacaoId);
        }
    }
}
