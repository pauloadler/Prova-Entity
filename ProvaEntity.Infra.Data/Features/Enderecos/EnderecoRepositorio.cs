using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProvaEntity.Domain.Features.Enderecos;
using ProvaEntity.Infra.Data.Contexts;

namespace ProvaEntity.Infra.Data.Features.Enderecos
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private ProvaEntityDbContext _contexto;

        public EnderecoRepositorio(ProvaEntityDbContext contexto)
        {
            _contexto = contexto;
        }

        public Endereco Salvar(Endereco endereco)
        {
            _contexto.Enderecos.Add(endereco);
            _contexto.SaveChanges();

            return endereco;
        }

        public Endereco ObterPorId(long id)
        {
            return _contexto.Enderecos.Where(c => c.Id == id).FirstOrDefault();
        }

        public IList<Endereco> ObterTodos()
        {
            return _contexto.Enderecos.ToList();
        }

        public void Atualizar(Endereco endereco)
        {
            _contexto.Entry(endereco).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Deletar(Endereco endereco)
        {
            _contexto.Enderecos.Remove(endereco);
            _contexto.SaveChanges();
        }
    }
}