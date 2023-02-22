using Infraestrutura.IoC;

namespace ProjetoClienteServico.Configuracoes
{
    public static class InjecaoDependenciaConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection servicos)
        {
            InjetorDependencia.Register(servicos);
        }
    }
}
