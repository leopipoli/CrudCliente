
namespace Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity>
    {
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
    }
}
