using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using FontFamily = System.Windows.Media.FontFamily;
using Newtonsoft.Json;
using AttributerUI.Model;
using TextBox = System.Windows.Controls.TextBox;
using System.Windows.Media.Imaging;

namespace AttributerUI.ViewModel
{
    class AttributeViewModel : BindableBase
    {
        private AttributeModel attributeModel;
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stkpnlDynamicControls2"></param>
        public AttributeViewModel(StackPanel stkpnlDynamicControls2)
        {
            attributeModel = new AttributeModel();
            attributeModel.stkPanel = stkpnlDynamicControls2;
            AddMethod();
           
        }
        // private void TextChnage()
        //{

        //}
        

        public AttributeModel TestModel
        {
            get { return attributeModel; }
            set { SetProperty(ref attributeModel, value); }
        }

        public Range Esri_BackgroundPressedBrush { get; private set; }

        /// <summary>
        /// Read controls from json file and deserialize it
        /// </summary>
        private void AddMethod()
        {
            string json = System.IO.File.ReadAllText(@"AttributeConfiguration.Json");
            List<AttributeList> jsoncontrols = JsonConvert.DeserializeObject<List<AttributeList>>(json);

            Grid rootGrid = new Grid();

            // Loop through List with for
            for (int i = 0; i < jsoncontrols.Count; i++) 
            {
                rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(100, GridUnitType.Auto) });
            }

            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(340, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(30, GridUnitType.Pixel) });

            for (int i = 0; i < jsoncontrols.Count; i++)
            {

                Label lb = new Label();
                lb.Content = jsoncontrols[i].Description;
                lb.FontSize = 12;
                lb.FontWeight = FontWeights.Regular;
                lb.FontFamily = new FontFamily("Segoe UI");
                lb.Padding = new Thickness(5, 5, 5, 15);
                Grid.SetRow(lb, i);
                Grid.SetColumn(lb, 0);
                rootGrid.Children.Add(lb);

                if (jsoncontrols[i].ControlType == "ComboBox")
                {                                         
                        System.Windows.Controls.ComboBox cb = new System.Windows.Controls.ComboBox();
                        cb.Items.Add(jsoncontrols[i].DefaultValue);
                        cb.FontSize = 12;
                        cb.FontWeight = FontWeights.Regular;
                        cb.FontFamily = new FontFamily("Segoe UI");
                        Grid.SetRow(cb, i);
                        Grid.SetColumn(cb, 0);
                        Grid.SetColumnSpan(cb, 2);
                        cb.Margin = new Thickness(5, 20, 0, 5);
                        cb.Padding = new Thickness(10, 2, 10, 2);
                        //rootGrid.Children.Add(lb);
                        rootGrid.Children.Add(cb);
                }             

                else if (jsoncontrols[i].ControlType == null) 
                {                                  
                    TextBox tb = new TextBox();                  
                    tb.Text = jsoncontrols[i].DefaultValue;                     
                    tb.Margin = new Thickness(5, 20, 0, 6);
                    tb.Padding = new Thickness(10, 2, 10, 2);
                    Grid.SetRow(tb, i);
                    Grid.SetColumn(tb, 0);
                    rootGrid.Children.Add(tb);

                    if (jsoncontrols[i].HelperTool != null)
                    {
                        System.Windows.Controls.Button btn = new System.Windows.Controls.Button();
                        btn.Margin = new Thickness(5, 20, 0, 10);
                        btn.Width = 25;
                        btn.Height = 20;
                        System.Windows.Controls.Image img = new System.Windows.Controls.Image();
                        Uri imageUri = new Uri("./DarkImages/imgB.png", UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        img.Source = imageBitmap;
                        img.Width = 35;
                        img.Height = 10;
                        btn.Content = img;

                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, 1);                      
                        rootGrid.Children.Add(btn);
                    }
                    else
                    {
                        Grid.SetColumnSpan(tb, 2);
                    }
                                     
                }
                if (jsoncontrols[i].Required == "TRUE")
                {
                    lb.Content = jsoncontrols[i].Description + "*";
                }
            }
            attributeModel.stkPanel.Children.Add(rootGrid);
        }
    }
}
