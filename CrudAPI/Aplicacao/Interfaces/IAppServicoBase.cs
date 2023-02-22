using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAppServicoBase<TEntity, TEntityDTO>
    {
        int Insert(TEntityDTO entityDTO);
        void Update(TEntityDTO entityDTO);
        void Delete(int id);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();

    }
}
