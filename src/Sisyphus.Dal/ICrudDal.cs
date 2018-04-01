using System.Collections.Generic;

namespace Sisyphus.Dal
{
    public interface ICrudDal<TEntity>
    {
        void Delete(int id);
        IEnumerable<TEntity> FindAll();
        TEntity FindByID(int id);
        int? Insert(TEntity entity);
        void Update(TEntity entity);
    }
}