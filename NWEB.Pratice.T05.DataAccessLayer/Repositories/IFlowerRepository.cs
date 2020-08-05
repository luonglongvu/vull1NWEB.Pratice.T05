using NWEB.Pratice.T05.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWEB.Pratice.T05.DataAccessLayer.Repositories
{
    public interface IFlowerRepository<TEntity> where TEntity : class,IGenericRepository<Flower>
    {
        int Create(TEntity entity);

        Task<int> CreateAsync(TEntity entity);

        bool Update(TEntity entity);

        Task<bool> UpdateAsync(TEntity entity);

        bool Delete(TEntity entity);

        Task<bool> DeleteAsync(TEntity entity);
    }
}
