using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Crud.EF.Services
{
    public class NonqueryDataService<T> where T : class
    {

        private readonly StudentContextFactory _contextFactory;
        private readonly NonqueryDataService<T> _nonQueryDataService;

        public NonqueryDataService(StudentContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// <summary>
        /// Adding student data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Create(T entity)
        {
            EntityEntry<T> createdResult = null;
            try
            {
                using StudentDBContext context = _contextFactory.CreateDbContext();
                createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                MessageBox.Show("Data  Added Successfully");
                return createdResult.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
           
        }

        /// <summary>
        /// Delete student data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> Delete(T entity)
        {

            using StudentDBContext context = _contextFactory.CreateDbContext();
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            MessageBox.Show("Data Successfully Deleted");
            return true;
        }

        /// <summary>
        /// Update Student data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> Update(T entity)
        {
            using StudentDBContext context = _contextFactory.CreateDbContext();
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
            MessageBox.Show("Data Successfully Updated");
            return entity;
        }
    }
}