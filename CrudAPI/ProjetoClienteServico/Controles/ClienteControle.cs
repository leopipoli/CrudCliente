using Microsoft.AspNetCore.Mvc;
using Dominio.Interfaces.Servicos;
using ProjetoClienteServico.Controles;
using Dominio.Entidades;
using Aplicacao.DTO;
using Aplicacao.Interfaces;

namespace ProjetoClienteServico.Controllers
{
    public class ClienteController : ControleBase<Cliente, ClienteDto>
    {
        public ClienteController(IClienteAppService app) : base(app)
        {

        }
    }
}