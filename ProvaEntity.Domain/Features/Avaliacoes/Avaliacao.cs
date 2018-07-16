using ProvaEntity.Domain.Base;
using System;

namespace ProvaEntity.Domain.Features.Avaliacoes
{
    public class Avaliacao : Entidade
    {
        public DateTime Data { get; set; }

        public override void Validar()
        {
            throw new System.NotImplementedException();
        }
    }
}
