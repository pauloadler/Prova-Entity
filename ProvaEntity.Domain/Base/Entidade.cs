namespace ProvaEntity.Domain.Base
{
    public abstract class Entidade
    {
        public long Id { get; set; }

        public abstract void Validar();
    }
}
