using ProvaEntity.Domain.Base;

namespace ProvaEntity.Domain.Features.Enderecos
{
    public class Endereco : Entidade
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
