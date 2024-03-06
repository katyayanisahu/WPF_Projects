
using Crud.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crud.EF.Services
{
     public class GenericDataService<T> : IDataService<T> where T : class
    {
        private readonly StudentContextFactory _contextFactory;
        private readonly NonqueryDataService<T> _nonQueryDataService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contextFactory"></param>
        public GenericDataService(StudentContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonqueryDataService<T>(contextFactory);
        }

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Create(T entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        /// <summary>
        /// Delete method 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> Delete(T entity)
        {
            return await _nonQueryDataService.Delete(entity);
        }

        /// <summary>
        /// Get method to retrieve data using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> Get(int id)
        {
            using StudentDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// GetAll method which retrieve all data of student
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAll()
        {
            using StudentDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().ToListAsync();          
        }

        /// <summary>
        /// Update method to update/edit any data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Update(T entity)
        {
            return await _nonQueryDataService.Update(entity);
        }
    }
}