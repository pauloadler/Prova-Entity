using System.Collections.Generic;

namespace ProvaEntity.Domain.Base
{
    public interface IRepositorio<T> where T : Entidade
    {
        T Salvar(T entidade);
        void Atualizar(T entidade);
        void Deletar(T entidade);
        IList<T> ObterTodos();
        T ObterPorId(long id);
    }
}
