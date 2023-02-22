using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.Interfaces;
using AutoMapper;
using Dominio.Interfaces.Servicos;

namespace Aplicacao.Servicos
{
    public class AppServicoBase<TEntity, TEntityDTO> : IAppServicoBase<TEntity, TEntityDTO>
    {
        protected readonly IMapper _mapper;
        protected readonly IServicoBase<TEntity> _servico; // Domain Service

        public AppServicoBase(IMapper mapper, IServicoBase<TEntity> servico)
        {
            _mapper = mapper;
            _servico = servico;
        }

        public int Insert(TEntityDTO entityDTO)
        {
            //Mapeia um objeto DTO para Entity
            TEntity entity = _mapper.Map<TEntity>(entityDTO);

            //Chama o Serviço do Domínio
            return _servico.Insert(entity);
        }

        public void Update(TEntityDTO entityDTO)
        {
            _servico.Update(_mapper.Map<TEntity>(entityDTO));
        }

        public void Delete(int id)
        {
            _servico.Delete(id);
        }

        public TEntityDTO GetById(int id)
        {
            return _mapper.Map<TEntityDTO>(_servico.GetById(id));
        }

        public IEnumerable<TEntityDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<TEntityDTO>>(_servico.GetAll());
        }
    }
}
