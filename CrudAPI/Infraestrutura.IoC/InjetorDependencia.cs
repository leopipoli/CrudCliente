using Aplicacao.Interfaces;
using Aplicacao.Servicos;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;
using Dominio.Servicos;
using Infraestrutura.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestrutura.IoC
{
    public class InjetorDependencia
    {
        public static void Register(IServiceCollection svcCollection)
        {
            // Application
            svcCollection.AddScoped(typeof(IAppServicoBase<,>), typeof(AppServicoBase<,>));
            svcCollection.AddScoped<IClienteAppService, ClienteAppServico>();

            // Domain
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IClienteServico, ClienteServico>();

            // Infra.Data
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        }
    }
}
