using ProvaEntity.Domain.Features.Alunos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProvaEntity.Infra.Data.Features.Alunos
{
    public class AlunoEntityConfiguracao : EntityTypeConfiguration<Aluno>
    {
        public AlunoEntityConfiguracao()
        {
            ToTable("TBAluno");
            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Nome).HasColumnName("nome").IsRequired();
            this.Property(a => a.Idade).HasColumnName("idade").IsRequired();

            this.Property(a => a.EnderecoId).HasColumnName("endereco_id").IsRequired();
            this.HasRequired(a => a.Endereco).WithMany().HasForeignKey(a => a.EnderecoId);
        }
    }
}
