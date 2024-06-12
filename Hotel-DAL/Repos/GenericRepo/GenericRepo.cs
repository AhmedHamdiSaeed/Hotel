using Hotel_DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_DAL.Repos.GenericRepo
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        protected HotelDbContext _HotelDbContext;
        public GenericRepo(HotelDbContext hotelDbContext)
        {
            _HotelDbContext = hotelDbContext;
        }
        public async Task Add(TEntity obj)
        {
            await _HotelDbContext.Set<TEntity>().AddAsync(obj);
            await _HotelDbContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity obj)
        {
              _HotelDbContext.Set<TEntity>().Remove(obj);
               await _HotelDbContext.SaveChangesAsync();
        }

        public async Task Edit(TEntity obj)
        {
            _HotelDbContext.Set<TEntity>().Update(obj);
            await _HotelDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>?> getAll()
        {
            return await _HotelDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> getById(int id)
        {
            return await _HotelDbContext.Set<TEntity>().FindAsync(id);
        }
    }
}
