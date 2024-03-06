using Crud.domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;

namespace Crud.EF
{
    public class StudentDBContext : DbContext
    {
        /// <summary>
        /// Readonly property
        /// </summary>
        public DbSet<Student> Student { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
           
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public StudentDBContext()
        {
        }
        public StudentDBContext(DbContextOptions options) : base(options)
        {
            
        }

         /// <summary>
        /// Defined field id as primary key
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(e => e.id);
        }
    }
}