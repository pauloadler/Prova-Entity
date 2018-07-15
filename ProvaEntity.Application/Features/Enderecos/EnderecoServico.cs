using System;
using System.Collections.Generic;
using ProvaEntity.Domain.Features.Enderecos;

namespace ProvaEntity.Application.Features.Enderecos
{
    public class EnderecoServico : IEnderecoServico
    {
        private IEnderecoRepositorio _enderecoRepository;

        public EnderecoServico(IEnderecoRepositorio EnderecoRepository)
        {
            _enderecoRepository = EnderecoRepository;
        }

        public Endereco Salvar(Endereco entidade)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Endereco entidade)
        {
            throw new NotImplementedException();
        }

        public Endereco ObterPorId(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Endereco> ObterTodos()
        {
            throw new NotImplementedException();
        }
        
        public void Deletar(Endereco entidade)
        {
            throw new NotImplementedException();
        }
    }
}
