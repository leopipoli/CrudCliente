using Infraestrutura.Data.Contextos;
using Microsoft.EntityFrameworkCore;

namespace ProjetoClienteServico.Configuracoes
{
    public static class DatabaseConfig
    {
        public static void AddDatabseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddDbContext<Contexto>(opts =>
                opts.UseNpgsql(configuration.GetConnectionString("Default")));
        }

    }
}
