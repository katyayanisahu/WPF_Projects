using Crud.domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ServiceStack.Configuration;
using System;
using System.Configuration;
using System.IO;

namespace Crud.EF
{
    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDBContext>
    {
        /// <summary>
        /// Create CreateDbContext method for database connection
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        /// 
       
        public StudentDBContext CreateDbContext(string[] args = null)
        {
             IConfigurationRoot configuration = new ConfigurationBuilder()               
                    .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"\FARRAGAUTUI\StudentCrudApplication1\StudentCrudApplication1\Crud.UI")))
                    .AddJsonFile("appsettings.json")
                    .Build();
                var builder = new DbContextOptionsBuilder<StudentDBContext>();
                //string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
                var connectionString = configuration.GetConnectionString("WPF_Connection");
                builder.UseSqlServer(connectionString);
                return new StudentDBContext(builder.Options);
        }
    }
}