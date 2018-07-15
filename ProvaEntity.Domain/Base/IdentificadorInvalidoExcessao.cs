namespace ProvaEntity.Domain.Base
{
    public class IdentificadorInvalidoExcessao : ExcessaoNegocio
    {
        public IdentificadorInvalidoExcessao() : base("O Id deve ser válido")
        {
        }
    }
}
