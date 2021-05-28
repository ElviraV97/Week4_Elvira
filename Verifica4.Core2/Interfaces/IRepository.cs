using System.Collections.Generic;

namespace Verifica4.Core2.Interfaces
{
    public interface IRepository<TEntity>
    {
        List<TEntity> Fetch();
        TEntity GetById(int id);
        bool Add(TEntity item);
        bool Update(TEntity item);
        bool Delete(TEntity item);
    }
}