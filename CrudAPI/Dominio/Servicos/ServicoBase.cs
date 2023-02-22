using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces.Repositorios;
using Dominio.Interfaces.Servicos;

namespace Dominio.Servicos
{
    public class ServicoBase<TEntity> : IServicoBase<TEntity>
    {
        protected readonly IRepositorioBase<TEntity> _repositorio;

        public ServicoBase(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public int Insert(TEntity entity)
        {
            return _repositorio.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _repositorio.Update(entity);
        }

        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public TEntity GetById(int id)
        {
            return _repositorio.FindById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorio.FindAll();
        }

    }
}
