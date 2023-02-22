using Aplicacao.DTO;
using AutoMapper;
using Dominio.Entidades;

namespace Aplicacao
{
    public class EntidadeMap : Profile
    {
        public EntidadeMap()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();
        }
    }
}
