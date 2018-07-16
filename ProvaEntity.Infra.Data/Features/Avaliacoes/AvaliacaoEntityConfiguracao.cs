using ProvaEntity.Domain.Features.Avaliacoes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProvaEntity.Infra.Data.Features.Avaliacoes
{
    public class AvaliacaoEntityConfiguracao : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoEntityConfiguracao()
        {
            ToTable("TBAvaliacao");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Data).HasColumnName("data").IsRequired();
        }
    }
}
