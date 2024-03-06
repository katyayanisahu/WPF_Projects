using Prism.Mvvm;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using Newtonsoft.Json;
using OverlayCalculation.Model;
using System.Windows.Media;
using System.Collections.ObjectModel;
using Farragut.Core;
using System.Windows.Data;

namespace OverlayCalculation.ViewModel
{
    class OverlayViewModel : BindableBase
    {
        private OverlayModel overlayModel;
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stkpnlDynamicControls"></param>
        public OverlayViewModel(System.Windows.Controls.StackPanel stkpnlDynamicControls2)
        {

            overlayModel = new OverlayModel();
            overlayModel.stkPanel = stkpnlDynamicControls2;
            AddMethod();

        }

        public OverlayModel TestModel
        {
            get { return overlayModel; }
            set { SetProperty(ref overlayModel, value); }
        }

        public Range Esri_BackgroundPressedBrush { get; private set; }
        public ObservableCollection<DataGridViewConfigurations> Tabs { get; private set; }

        /// <summary>
        /// Read controls from json file and deserialize it
        /// </summary>
        private void AddMethod()
        {
            string json1 = System.IO.File.ReadAllText(@"OverlayConfig.Json");

            var jsoncontrols = JsonConvert.DeserializeObject<Root>(json1);

            //var jsoncontrols = JsonConvert.DeserializeObject<DataGridViewConfigurations>(json1);

            Grid rootGrid = new Grid();

            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });
            rootGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) });

            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(500, GridUnitType.Pixel) });
            rootGrid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(400, GridUnitType.Pixel) });

           
            for (int i = 0; i < jsoncontrols.DataGridViewConfigurations.DataGridView.Count; i++)
            {
                //Tab Control
                System.Windows.Controls.TabControl tabControl = new System.Windows.Controls.TabControl();

            Grid.SetColumn(tabControl, 1);
            Grid.SetRow(tabControl, 0);
            Grid.SetColumnSpan(tabControl, 2);
            tabControl.BorderThickness.Equals(1);

            tabControl.Width = 580;
            tabControl.Height = 299;
            tabControl.Margin = new Thickness(200, 6.5, 0, 5);
            tabControl.HorizontalAlignment = HorizontalAlignment.Left;
            tabControl.VerticalAlignment=VerticalAlignment.Top;

               
                for (int j = 0; j < jsoncontrols.DataGridViewConfigurations.DataGridView.Count; j++)
                {
                    
                    TabItem ti = new TabItem();
                    ti.Header = jsoncontrols.DataGridViewConfigurations.DataGridView[j].TabName;           

                    DataGrid dataGrid = new DataGrid();
                    //dataGrid.Background = 
                    for (int k = 0; k < jsoncontrols.DataGridViewConfigurations.DataGridView[j].DisplayColumns.Column.Count; k++)
                    {

                        if (jsoncontrols.DataGridViewConfigurations.DataGridView[j].
                            DisplayColumns.Column[k].Alias==null)
                        {
                            var AddItem = jsoncontrols.DataGridViewConfigurations.DataGridView[j].
                            DisplayColumns.Column[k].Name;
                            DataGridTextColumn c1 = new DataGridTextColumn();
                            c1.Header = AddItem;
                            c1.Binding = new Binding(AddItem);
                            c1.Width = 150;
                            dataGrid.Columns.Add(c1);
                            

                        }
                        else
                        {
                            var AddItem = jsoncontrols.DataGridViewConfigurations.DataGridView[j].
                         DisplayColumns.Column[k].Alias;
                            DataGridTextColumn c1 = new DataGridTextColumn();
                            c1.Header = AddItem;
                            c1.Binding = new Binding(AddItem);
                            c1.Width = 150;
                         
                            dataGrid.Columns.Add(c1);

                        }
                        


                    }
                    ti.Content = dataGrid;
                    tabControl.Items.Add(ti);

                }

                //Label
                System.Windows.Controls.Label lbl = new System.Windows.Controls.Label();
                lbl.Content = "Error(s):";
                Grid.SetRow(lbl, 1);
                Grid.SetColumn(lbl, 1);
                lbl.BorderThickness.Equals(1);

                lbl.Width = 500;
                lbl.Height = 29;
                lbl.Margin = new Thickness(200, 0, 0, 5);
                lbl.HorizontalAlignment = HorizontalAlignment.Left;
                lbl.VerticalAlignment = VerticalAlignment.Top;

                //ListBox 
                ListBox tb = new ListBox();
           
                Grid.SetColumn(tb, 1);
                Grid.SetRow(tb, 2);
                tb.Margin = new Thickness(200, 0, 0, 5);
                tb.HorizontalAlignment = HorizontalAlignment.Left;
                tb.VerticalAlignment = VerticalAlignment.Top;
                tb.Width = 580;
                tb.Height = 50;
                Grid.SetColumnSpan(tb, 2);

                //Button1

                System.Windows.Controls.Button btn = new System.Windows.Controls.Button();

                Grid.SetColumn(btn, 1);
                Grid.SetRow(btn, 3);

                btn.Height = 25;

                btn.Width = 130;

                btn.Content = "Show Overlay Layers";

                btn.Background = new SolidColorBrush(Colors.LightGray);

                btn.Foreground = new SolidColorBrush(Colors.Black);
                btn.Margin = new Thickness(200, 5, 0, 10);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                btn.VerticalAlignment = VerticalAlignment.Top;

                //Button2

                System.Windows.Controls.Button btn1 = new System.Windows.Controls.Button();

                Grid.SetColumn(btn1, 1);
                Grid.SetRow(btn1, 3);

                btn1.Height = 25;

                btn1.Width = 130;

                btn1.Content = "Hide Overlay Layers";

                btn1.Background = new SolidColorBrush(Colors.LightGray);

                btn1.Foreground = new SolidColorBrush(Colors.Black);
                btn1.Margin = new Thickness(340, 5, 0, 5);
                btn1.HorizontalAlignment = HorizontalAlignment.Left;
                btn1.VerticalAlignment = VerticalAlignment.Top;


                //Button3
                System.Windows.Controls.Button btn3 = new System.Windows.Controls.Button();

                Grid.SetColumn(btn3, 1);
                Grid.SetRow(btn3, 3);
                Grid.SetColumnSpan(btn3, 2);

                btn3.Height = 25;

                btn3.Width = 100;

                btn3.Content = "Save/Close";
                btn3.IsEnabled= false;

                btn3.Background = new SolidColorBrush(Colors.LightGray);

                btn3.Foreground = new SolidColorBrush(Colors.Black);
                btn3.Margin = new Thickness(570, 5, 0, 5);
                btn3.HorizontalAlignment = HorizontalAlignment.Left;
                btn3.VerticalAlignment = VerticalAlignment.Top;


                //Button4
                System.Windows.Controls.Button btn4 = new System.Windows.Controls.Button();

                Grid.SetColumn(btn4, 1);
                Grid.SetColumnSpan(btn4, 2);
                Grid.SetRow(btn4, 3);

                btn4.Height = 25;

                btn4.Width = 100;

                btn4.Content = "Cancel";

                btn4.Background = new SolidColorBrush(Colors.LightGray);

                btn4.Foreground = new SolidColorBrush(Colors.Black);
                btn4.Margin = new Thickness(680, 5, 0, 5);
                btn4.HorizontalAlignment = HorizontalAlignment.Left;
                btn4.VerticalAlignment = VerticalAlignment.Top;

                rootGrid.Children.Add(btn3);
                rootGrid.Children.Add(btn4);
                rootGrid.Children.Add(btn);
                rootGrid.Children.Add(btn1);
                rootGrid.Children.Add(tb);
                rootGrid.Children.Add(tabControl);
            }

         
            overlayModel.stkPanel.Children.Add(rootGrid);   
        }
    }
}
    

