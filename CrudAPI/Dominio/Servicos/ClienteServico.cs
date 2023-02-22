

using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;

namespace Dominio.Servicos
{
    public class ClienteServico : ServicoBase<Cliente>, IClienteServico
    {
        public ClienteServico(IClienteRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
