using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crud.Domain.Services
{
    public interface IDataService<T> // called as entity all table are entity #crud optation
    {
        /// <summary>
        /// Defined all methods to be implemented in the Service class
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);
    }
}