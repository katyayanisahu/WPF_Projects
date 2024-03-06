using Prism.Mvvm;
using SPRINTSUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using Newtonsoft.Json;
using System.Windows.Media.Imaging;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using FontFamily = System.Windows.Media.FontFamily;
using DocumentFormat.OpenXml.Office2016.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing;
using System.Windows.Controls.Primitives;
using Haley.WPF;
using System.IO;
using Stretch = DocumentFormat.OpenXml.Drawing.Stretch;

namespace SPRINTSUI.ViewModel
{
    class LoadTransactionViewModel : BindableBase

    {
     
        private LoadTransactionModel loadtransactionModel;

        public ICommand AddCommand { get; private set; }
        public LoadTransactionViewModel(StackPanel stkpnlDynamicControls2)
        {
            loadtransactionModel = new LoadTransactionModel();
            loadtransactionModel.stkPanel = stkpnlDynamicControls2;
            //AddCommand = new DelegateCommand();
            AddMethod();
            //CreateButtons();
        }

        public LoadTransactionModel TestModel
        {
            get { return loadtransactionModel; }
            set { SetProperty(ref loadtransactionModel, value); }
        }

        public Range Esri_BackgroundPressedBrush { get; private set; }

        private void AddMethod()
        {
             

        string json = System.IO.File.ReadAllText(@"Config1.json");

            List<LoadTransactionJsonControl> jsoncontrols = JsonConvert.DeserializeObject<List<LoadTransactionJsonControl>>(json);



            Grid rootGrid = new Grid();
        

            //rootGrid.Margin = new Thickness(10.0);
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(340, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(340, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(110, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(200, GridUnitType.Pixel) });
            //rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(170, GridUnitType.Pixel) });
            //rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            //rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });


            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
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
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });

            //for UI2
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
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
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });



            for (int i = 0; i < jsoncontrols.Count; i++)
            {

                if (jsoncontrols[i].Type == "Esri_TextBlockRegular")
                {
                    TextBox tb = new TextBox();
                    tb.Text = jsoncontrols[i].Content;
                   tb.FontFamily = new FontFamily("Segoe UI");
                    tb.FontWeight = FontWeights.Regular;
                   //tb.Foreground = DynamicResource App_Gray  ;


                    //if (jsoncontrols[i].LightTheme == "#005e95")
                    //{
                    //    tb.text.LightTheme = (SolidColorBrush)new BrushConverter().ConvertFromString(jsoncontrols[i].LightTheme);

                    //}

                    // tb..Background = Esri_BackgroundPressedBrush;
                    // tb.Light theme = jsoncontrols[i].light theme;

                    tb.FontSize = 12;
                    Grid.SetColumn(tb, jsoncontrols[i].column);
                    Grid.SetRow(tb, jsoncontrols[i].row);
                    tb.Margin = new Thickness(5, 0, 0, 5);

                    tb.Padding = new Thickness(10, 2, 10, 2);
                    Grid.SetColumnSpan(tb, jsoncontrols[i].ColumnSpan);

                    rootGrid.Children.Add(tb);

                }


                else if (jsoncontrols[i].Type == "Label")
                {
                    Label lbl = new Label();
                    lbl.Content = jsoncontrols[i].Content;

                    lbl.FontSize = 12;
                
                    lbl.FontFamily= new FontFamily("Segoe UI");
                    lbl.FontWeight = FontWeights.Regular;
                    //  lbl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(jsoncontrols[i].Background);

                    if (jsoncontrols[i].Foreground == "#005e95")
                    {
                        // lbl.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(jsoncontrols[i].Foreground);
                        lbl.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString(jsoncontrols[i].Foreground);
                        lbl.FontWeight = FontWeights.Bold;
                    }


                    //lbl.Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("Red");

                    Grid.SetColumn(lbl, jsoncontrols[i].column);
                    Grid.SetColumnSpan(lbl, jsoncontrols[i].ColumnSpan);
                    Grid.SetRow(lbl, jsoncontrols[i].row);
                    rootGrid.Children.Add(lbl);
                }


                else if (jsoncontrols[i].Type == "ComboBox")
                {
                    ComboBox cb = new ComboBox();

                    //cb.Width = jsoncontrols[i].Width;
                    //cb.Height = jsoncontrols[i].Height;
                    cb.Margin = new Thickness(5, 5, 0, 5);
                   // cb.Background = (SolidColorBrush)new BrushConverter().ConvertFromString(jsoncontrols[i].Background); 
                    //  cb.Items.Add(1);

                    Grid.SetColumn(cb, jsoncontrols[i].column);
                    Grid.SetColumnSpan(cb, jsoncontrols[i].ColumnSpan);
                    Grid.SetRow(cb, jsoncontrols[i].row);

                    cb.FontWeight = FontWeights.Regular;
                   cb.FontFamily = new FontFamily("Segoe UI");
                    cb.FontSize = 12;

                    ComboBoxItem item = new ComboBoxItem();
                    item.Content = "N";
                    cb.Items.Add(item);
                    cb.Items.Add("A");
                    cb.Items.Add("B");
                    cb.Items.Add("C");
                    cb.Items.Add("D");
                    cb.Items.Add("E");

                    rootGrid.Children.Add(cb);
                }
                else if (jsoncontrols[i].Type == "Esri_ImageTrayButton")
                {
                    //FileStream stream = new FileStream("picture.png", FileMode.Open, FileAccess.Read);
                    //Image i = new Image();
                    //BitmapImage src = new BitmapImage();
                    //src.BeginInit();
                    //src.StreamSource = stream;
                    //src.EndInit();
                    //i.Source = src;


                    System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                    Uri imageUri = new Uri(jsoncontrols[i].Path, UriKind.Relative);
                    BitmapImage imageBitmap = new BitmapImage(imageUri);
                    img.Source = imageBitmap;
                    img.Width = jsoncontrols[i].Width;
                    img.Height = jsoncontrols[i].Height;
                    // img.Margin = new Thickness(0, 0, 5, 0);
                    img.HorizontalAlignment = HorizontalAlignment.Right;
                    Grid.SetColumn(img, jsoncontrols[i].column);
                    Grid.SetRow(img, jsoncontrols[i].row);
                    rootGrid.Children.Add(img);

                }


            }
            loadtransactionModel.stkPanel.Children.Add(rootGrid);
        }

    

       
    }
}
