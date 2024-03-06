using Crud.domain.Model;
using Crud.EF;
using Newtonsoft.Json;
using Prism.Services.Dialogs;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Crud.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public enum MessageBoxButtons
        //{
        //    OK,
        //    OKCancel,
        //    YesNo,
        //    YesNoCancel
        //}

        /// <summary>
        /// private readonly property
        /// </summary>
        private readonly StudentCrudServices _crudServices;

       // public object MessageBoxButtons { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            _crudServices = new StudentCrudServices();
            ButtonAdd.Click += ButtonAdd_Click;
            ButtonList.Click += ButtonList_Click;
            DataGridBrand.SelectionChanged += DataGridBrand_SelectionChanged;
            ButtonEdit.Click += ButtonEdit_Click;
            ButtonDelete.Click += ButtonDelete_Click;
            ButtonSearch.Click += ButtonSearch_Click;
        }
        /// <summary>
        /// Update button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private async void ButtonEdit_Click(object sender, RoutedEventArgs e)
       {
           try
            {
                string msgtext = "Do you want to update data?";
                string txt = "Dialog box";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

                switch (result)
                {
                    case MessageBoxResult.Yes:
                        if (txtStudentID.Text != string.Empty && txtStudent.Text != string.Empty)
                        {
                            await _crudServices.UpdateBrand(int.Parse(txtStudentID.Text), txtStudent.Text, txtCourse.Text);
                            //throw new Exception("Data Successfully Updated");
                        }

                        break;
                    case MessageBoxResult.No:

                        break;
                    
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await ListBrands();
            }
       }

        /// <summary>
        /// Delete button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {

                string msgtext = "Do you want to delete data?";
                string txt = "Confirmation box";
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxResult result = MessageBox.Show(msgtext, txt, button);

                switch (result)
                {
                    case MessageBoxResult.Yes:
                        if (txtStudentID.Text != string.Empty && txtStudent.Text != string.Empty && txtCourse.Text != string.Empty)
                        {
                            await _crudServices.DeleteBrand(int.Parse(txtStudentID.Text));
                            //throw new Exception("Data Successfully Deleted");
                        }
                        break;
                    case MessageBoxResult.No:

                        break;
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await ListBrands();
            }
        }

        /// <summary>
        /// Search button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private async void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
           
            var SearchName = await _crudServices.SearchBrandByName(txtStudent.Text);
          
            if (SearchName == null || SearchName.ToList().Count==0)
            {

                MessageBox.Show("Data not found");

                return;

            }
            else
            
                DataGridBrand.ItemsSource = SearchName.ToList();
               
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridBrand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
               var activelist = (Student)DataGridBrand.CurrentItem;
                if (activelist != null)
                {
                    txtStudentID.Text = activelist.id.ToString();
                    txtStudent.Text = activelist.name;
                    txtCourse.Text = activelist.course;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Show list of data on list button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonList_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await ListBrands();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Get data from json file and show all list in the grid
        /// </summary>
        /// <returns></returns>
        private async Task ListBrands()
        {
            var brandList = await _crudServices.ListBrands();
            brandList.AddRange(GetJsonData());
            DataGridBrand.ItemsSource = brandList.ToList();
        }

        /// <summary>
        /// Read data from stud.json file and deserialize it
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<Student> GetJsonData()
        {
            string json = System.IO.File.ReadAllText(@"stud.json");
            return JsonConvert.DeserializeObject<ObservableCollection<Student>>(json);          
        }

        /// <summary>
        /// Add data on clicking Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            { 

                _crudServices.AddBrand(txtStudent.Text, txtCourse.Text);              
                //throw new Exception("Data Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtStudentID.Clear();
                txtStudent.Clear();
                txtCourse.Clear();
                txtStudentID.Focus();
            }
        }
    }
}