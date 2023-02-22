using Aplicacao;

namespace ProjetoClienteServico.Configuracoes 
{ 
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new EntidadeMap()));
        }
    }
}