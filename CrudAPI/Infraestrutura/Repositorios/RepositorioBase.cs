using Dominio.Entidades;
using Dominio.Interfaces.Repositorios;
using Infraestrutura.Data.Contextos;
using Microsoft.EntityFrameworkCore;


namespace Infraestrutura.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity>
        where TEntity : EntidadeBase

    {
        protected readonly Contexto contexto;

        public RepositorioBase(Contexto contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public int Insert(TEntity entity)
        {
            contexto.InitTransaction();

            var id = contexto.Set<TEntity>().Add(entity).Entity.Id;

            contexto.SendChanges();

            return id;
        }

        public void Update(TEntity entity)
        {
            contexto.InitTransaction();

            contexto.Set<TEntity>().Attach(entity);

            contexto.Entry(entity).State = EntityState.Modified;

            contexto.SendChanges();
        }

        public void Delete(int id)
        {
            var entity = FindById(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            contexto.InitTransaction();
            contexto.Set<TEntity>().Remove(entity);

            contexto.SendChanges();
        }

        public TEntity FindById(int id)
        {
            
            return contexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return contexto.Set<TEntity>().ToList();
        }

    }
}
