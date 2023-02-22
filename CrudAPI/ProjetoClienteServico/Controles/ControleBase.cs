using Aplicacao.Interfaces;
using Dominio.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoClienteServico.Controles
{
    [Route("api/[controller]")]
    abstract public class ControleBase<Entity, EntityDTO> : Controller
    {
        readonly protected IAppServicoBase<Entity, EntityDTO> _appService;

        public ControleBase(IAppServicoBase<Entity, EntityDTO> appService)
        {
            _appService = appService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll([FromServices] IClienteServico servico)
        {
            try
            {
                var clientes = _appService.GetAll();

                return new OkObjectResult(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var cliente = _appService.GetById(id);

                return new OkObjectResult(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("")]
        public IActionResult Insert([FromBody] EntityDTO dados)
        {
            try
            {
                return new OkObjectResult(_appService.Insert(dados));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromBody] EntityDTO dados)
        {
            try
            {
                _appService.Update(dados);

                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _appService.Delete(id);

                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
