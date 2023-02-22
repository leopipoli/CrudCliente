using Aplicacao.DTO;
using Aplicacao.Interfaces;
using AutoMapper;
using Dominio.Entidades;
using Dominio.Interfaces.Servicos;

namespace Aplicacao.Servicos
{
    public class ClienteAppServico : AppServicoBase<Cliente, ClienteDto>, IClienteAppService
    {
        public ClienteAppServico(IMapper mapper, IServicoBase<Cliente> servico) : base(mapper, servico)
        {
        }
    }
}
