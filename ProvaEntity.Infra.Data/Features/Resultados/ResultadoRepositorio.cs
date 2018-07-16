using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProvaEntity.Domain.Features.Alunos;
using ProvaEntity.Domain.Features.Resultados;
using ProvaEntity.Infra.Data.Contexts;

namespace ProvaEntity.Infra.Data.Features.Resultados
{
    public class ResultadoRepositorio : IResultadoRepositorio
    {
        private ProvaEntityDbContext _contexto;

        public ResultadoRepositorio(ProvaEntityDbContext contexto)
        {
            _contexto = contexto;
        }

        public Resultado Salvar(Resultado resultado)
        {
            _contexto.Resultados.Add(resultado);
            _contexto.SaveChanges();

            return resultado;
        }

        public void Atualizar(Resultado resultado)
        {
            _contexto.Entry(resultado).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public Resultado ObterPorId(long id)
        {
            return _contexto.Resultados.Where(c => c.Id == id).FirstOrDefault();
        }

        public IList<Resultado> ObterTodos()
        {
            return _contexto.Resultados.ToList();
        }

        public IList<Resultado> BuscarResultadosPorAlunoId(long alunoId)
        {
            return _contexto.Resultados.Where(r => r.AlunoId == alunoId).ToList();
        }
        
        public void Deletar(Resultado resultado)
        {
            _contexto.Resultados.Remove(resultado);
            _contexto.SaveChanges();
        }
    }
}
