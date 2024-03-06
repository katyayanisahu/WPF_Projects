using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using wpf_jsoncontrols.Models;

namespace wpf_jsoncontrols.ViewModels
{
    class TestViewModel : BindableBase
    {
        private TestModel testModel;
        private BrushConverter bc;

        public ICommand AddCommand { get; private set; }
        public TestViewModel(StackPanel stkpnlDynamicControls)
        {
            testModel = new TestModel();
            TestModel.stkPanel = stkpnlDynamicControls;
            //AddCommand = new DelegateCommand();
            AddMethod();
        }
        public TestModel TestModel
        {
            get { return testModel; }
            set { SetProperty(ref testModel, value); }
        }
        private void AddMethod()
        {
            string json = System.IO.File.ReadAllText(@"config.json");


            List<jsoncontrols> jsoncontrols = JsonConvert.DeserializeObject<List<jsoncontrols>>(json);

            Grid rootGrid = new Grid();
          

            //rootGrid.Margin = new Thickness(10.0);
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30, GridUnitType.Pixel)});
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(250, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(230, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(170, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
           rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });


            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
           
          
            for (int i=0;i< jsoncontrols.Count;i++)
            {
                if (jsoncontrols[i].Type == "CheckBox")
                {
                    CheckBox cbox = new CheckBox();
                    cbox.Content = jsoncontrols[i].Content;
                    cbox.Margin = new Thickness(0, 5, 95, 5);
                    Grid.SetColumn(cbox, jsoncontrols[i].column);
                    Grid.SetColumnSpan(cbox, jsoncontrols[i].ColumnSpan);
                    Grid.SetRow(cbox, jsoncontrols[i].row);
                    rootGrid.Children.Add(cbox);
                }
                else if (jsoncontrols[i].Type == "TextBox")
                {
                    TextBox tb = new TextBox();
                    tb.Text = jsoncontrols[i].Content;
                    //tb.Width= jsoncontrols[i].Width;
                    Grid.SetColumn(tb, jsoncontrols[i].column);
                    Grid.SetRow(tb, jsoncontrols[i].row);
                    tb.Margin = new Thickness(80, 5, 0, 5);
                    //tb.Background = new SolidColorBrush(Colors.#DFDFDF);
                   // tb.Background = new SolidColorBrush(Color.FromArgb(#DFDFDF));

                   tb.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#F8F8F8");
                    // tb.Padding = new Thickness(0, 2, 0, 2);
                    Grid.SetColumnSpan(tb, jsoncontrols[i].ColumnSpan);

                    //tb.Margin = new Thickness(Convert.ToDouble(jsoncontrols[i].Margin));
                    //tb.Margin.Top = System.Windows.Thickness[jsoncontrols[i].TopMargin];
                    rootGrid.Children.Add(tb);

                }
                else if (jsoncontrols[i].Type == "Button")
                {
                    Button btn = new Button();
                    btn.Content = jsoncontrols[i].Content;
                    btn.Width = jsoncontrols[i].Width;
                    btn.Height = jsoncontrols[i].Height;
                   // btn.HorizontalAlignment = HorizontalAlignment.Left;
                  
                    Grid.SetColumn(btn, jsoncontrols[i].column);
                    Grid.SetRow(btn, jsoncontrols[i].row);
                    btn.Margin = new Thickness(5, 70, 5, 70);
                   btn.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#F8F8F8");
                    // btn.Margin = new Thickness(Convert.ToDouble(jsoncontrols[i].Margin));

                    btn.Padding = new Thickness(5, 0, 5, 0);
                    Grid.SetColumnSpan(btn, jsoncontrols[i].ColumnSpan);

                    rootGrid.Children.Add(btn);
                }


                else if (jsoncontrols[i].Type == "image")
                {
                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    Uri imageUri = new Uri(jsoncontrols[i].Path, UriKind.Relative);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);

                    img.Source = imageBitmap;
                    img.Width = jsoncontrols[i].Width;
                    img.Height = jsoncontrols[i].Height;
                    img.Margin = new Thickness(0, 0, 5, 0);
                    img.HorizontalAlignment = HorizontalAlignment.Left;
                    Grid.SetColumn(img, jsoncontrols[i].column);
                    Grid.SetRow(img, jsoncontrols[i].row);
                    rootGrid.Children.Add(img);

                }
              
            }
       

            TestModel.stkPanel.Children.Add(rootGrid);
        }
   
    }
}
