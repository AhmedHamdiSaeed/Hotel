using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.GenericRepo
{
    public interface IGenericRepo<TEntity>
    {
        Task<IEnumerable<TEntity>?> getAll();
        Task Add(TEntity obj);
        Task<TEntity?> getById(int id);
        Task Edit(TEntity obj);
        Task Delete(TEntity obj);
    }
}
