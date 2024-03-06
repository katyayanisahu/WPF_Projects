using Crud.domain.Model;
using Crud.EF.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Crud.Domain.Services;
using System.Windows;

namespace Crud.EF
{
    public class StudentCrudServices : ICrud
    {
        private readonly IDataService<Student> _crudServices;
        private ObservableCollection<Student> listOfTask;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public StudentCrudServices()
        {
            _crudServices = new GenericDataService<Student>(new StudentContextFactory());
            listOfTask = new ObservableCollection<Student>();
            GetJsonData();
        }

        /// <summary>
        ///  Read data from stud.json file
        /// </summary>
        private void GetJsonData()
        {
            string json = System.IO.File.ReadAllText(@"stud.json");
            listOfTask = JsonConvert.DeserializeObject<ObservableCollection<Student>>(json);
        }
        public ObservableCollection<Student> ListOfTask
        {
            get { return listOfTask; }
            set
            {
                listOfTask = value;
            }
        }
       
        /// <summary>
        /// Add student data
        /// </summary>
        /// <param name="stname"></param>
        /// <param name="course"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Student> AddBrand(string name, string course)
        {
            try
            {
                if (name == string.Empty)
                {
                    throw new Exception("Student Name Cannot be Empty");
                }
           
                else
                {
                    bool stud = false;
                    var students = (List<Student>)await _crudServices.GetAll();
                     students.ForEach(x =>
                    {

                        if (x.name == name && x.course == course)
                        {
                            stud= true;
                           
                        }
                        
                    });
                    if (stud)
                    {
                        MessageBox.Show("Duplicate found");
                        return students[0];
                    }
                    else
                    {
                        Student br = new Student
                        {
                            name = name,
                            course = course
                        };
                        return await _crudServices.Create(br);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Delete student data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<bool> DeleteBrand(int id)
        {
            try
            {
                Student delete = await SearchBrandbyID(id);
                return await _crudServices.Delete(delete);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Get list of Student data
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<Student>> ListBrands()
        {
            try
            {
                return (List<Student>)await _crudServices.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Search data using ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Task<Student> SearchBrandbyID(int ID)
        {
            try
            {
                return _crudServices.Get(ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Search data using Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<ICollection<Student>> SearchBrandByName(string name)
        {
            try
            {
                var listbrand = await ListBrands();
                
                return listbrand.Where(x => x.name.StartsWith(name)).ToList();
              
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        /// <summary>
        /// Update student data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="course"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<Student> UpdateBrand(int id, string name, string course)
        {
            try
            {              
                Student br = await SearchBrandbyID(id);
                if (br == null)
                {
                    MessageBox.Show("Not found");
                    return null;

                }
                else
                {
                    br.name = name;
                    br.course = course;
                    return await _crudServices.Update(br);
                   
                }
                
            }
            catch (Exception ex)
            {
               
                throw new Exception(ex.Message);

            }
        }       
    }
}