using ProvaEntity.Domain.Base;
using ProvaEntity.Domain.Features.Alunos;
using System.Collections.Generic;

namespace ProvaEntity.Domain.Features.Resultados
{
    public interface IResultadoRepositorio : IRepositorio<Resultado>
    {
        IList<Resultado> BuscarResultadosPorAlunoId(long alunoId);
    }
}
