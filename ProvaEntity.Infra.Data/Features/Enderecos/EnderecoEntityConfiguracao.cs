using ProvaEntity.Domain.Features.Enderecos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProvaEntity.Infra.Data.Features.Enderecos
{
    public class EnderecoEntityConfiguracao : EntityTypeConfiguration<Endereco>
    {
        public EnderecoEntityConfiguracao()
        {
            ToTable("TBEndereco");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(x => x.Logradouro).HasColumnName("logradouro").IsRequired();
            this.Property(x => x.Bairro).HasColumnName("bairro").IsRequired();
        }
    }
}
