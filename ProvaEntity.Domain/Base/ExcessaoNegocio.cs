using System;

namespace ProvaEntity.Domain.Base
{
    public class ExcessaoNegocio : Exception
    {
        public ExcessaoNegocio(string message) : base(message)
        {
        }
    }
}
