using Microsoft.OpenApi.Models;

namespace ProjetoClienteServico.Configuracoes
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection servicos)
        {
            servicos.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Cliente.Services.Api",
                    Version = "v1"
                });
            });
        }

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cliente.Services.Api v1"));
        }
    }
}
