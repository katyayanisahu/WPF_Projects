using Crud.domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF
{
    public interface ICrud
    {
        /// <summary>
        /// Defined methods to implement in GenericDataService class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="course"></param>
        /// <returns></returns>
        Task<Student> AddBrand(string name, string course);
        Task<bool> DeleteBrand(int id);
       
        Task<Student> SearchBrandbyID(int ID);
        Task<ICollection<Student>> SearchBrandByName(string name);
        Task<Student> UpdateBrand(int id, string name, string course);
    }
}
