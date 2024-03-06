using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUi2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = LoadCollectionData();
            dataGrid2.ItemsSource = LoadCollectionData1();
        }
        private List<Author2> LoadCollectionData()
        {
            List<Author2> authors = new List<Author2>();
            authors.Add(new Author2()
            {
               // _= "",
                OID = 10446,
                FEATURE_KEY = 10446,
                UPDATE_DELETE = "DELETE",
                ERROR_MESSAGE = "",
                
            });

           

            return authors;
        }
        //second DataGrid
        private List<Author> LoadCollectionData1()
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
               // _= "",
                OID = 216189,
                FEATURE_KEY = 206678,
                UPDATE_INSERT = "INSERT",
                ERROR_MESSAGE = "",
              
            });

            authors.Add(new Author()
            {
               // _="",
                OID = 216190,
                FEATURE_KEY = 206679,
                UPDATE_INSERT = "INSERT",
                ERROR_MESSAGE = "",
                
            });

          
            return authors;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
public class Author
{
    //public string _ { get; set; }

    public int OID { get; set; }
    public int FEATURE_KEY { get; set; }
    public string UPDATE_INSERT { get; set; }
    public string ERROR_MESSAGE { get; set; }
    
}
public class Author2
{
    //public string _ { get; set; }
    public int OID { get; set; }
    public int FEATURE_KEY { get; set; }
    public string UPDATE_DELETE { get; set; }
    public string ERROR_MESSAGE { get; set; }
    
}