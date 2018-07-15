using ProvaEntity.Domain.Base;
using System.Collections.Generic;

namespace ProvaEntity.Application.Base
{
    public interface IServico<T> where T : Entidade
    {
        T Salvar(T entidade);
        void Atualizar(T entidade);
        void Deletar(T entidade);
        IList<T> ObterTodos();
        T ObterPorId(long id);
    }
}
