using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Game.API.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T obj);
        Task UpdateAsync(T obj);
        IEnumerable<T> List();
        T GetById(Guid id);
        Task RemoveAsync(T obj);
    }
}
