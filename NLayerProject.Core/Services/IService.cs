using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    interface IService<TEntity>where TEntity:class
    {

        // ileride sql server yerine oracla kullandığımız zaman services katmanımız sabit kalır. tek değiştirmemiz gereken repository sınıflarımız o yüzden services katmanımızı oluşturduk. yoksa Irepository üzerinden de gidebilirdik..

        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entity);

        TEntity update(TEntity entity);
    }
}
