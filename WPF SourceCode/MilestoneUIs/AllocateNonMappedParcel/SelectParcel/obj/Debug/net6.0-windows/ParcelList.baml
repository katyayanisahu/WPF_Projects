   M S B A M L   `   `   `  ����`  \ArcGIS.Desktop.Framework, Version=13.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86wQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework!ArcGIS.Desktop.Framework.Controls  5   	   G CSelectParcel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SelectParcelSelectParcel 5   	   a ]ArcGIS.Desktop.Extensions, Version=13.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86hJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.ExtensionsArcGIS.Desktop.Extensions 5	   	      SelectParcel.ParcelList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   fcontrolsQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )uiclr-namespace:SelectParcel     5   	   a
extensionsJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.Extensions     5	   	     � Title$  
ParcelList��5   	   $	��350��6   $	��330��6)    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries<  6ArcGIS.Desktop.Extensions.DesignOnlyResourceDictionary   Source�� 5   
    5        5      $S Mpack://application:,,,/ArcGIS.Desktop.Framework;component\Themes\Default.xaml?�6:   %    5      .��5      � .+�5   
   �� $
��Auto=�6   .��5      � $��
0,0,4,-0.2q�6   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6(   68   �� 5      $
��auto �6(   68   �� 5      $
��auto �6(   68   .+�5!      �� -   5         ��Name$ listBox1��5!      $	��250��60   $	��310��6=   $��0��6I   $��0,10,5,0q�6V   ��6h   �� *Names1+53      55      � 56       57      �� 58      $
��auto �6(   68   �� 59      $
��auto �6(   68   �� 5:      $
��auto �6(   68    � ColumnDefinitions 5=      �� 5?      $
��auto �6+   �� 5@      $
��auto �6+   �� 5A      $
��auto �6+   �� 5B      $
��auto �6+   �� 5C      $
��auto �6+   �� 5D      $
��auto �6+   �� 5E      $
��auto �6+   �� 5F      $
��auto �6+   .+�5J      �� $��Cancel��6   $	��120��6.   $��25��6:   $��0��6F   $��14(�6T   ���#DFDFDF$��0��6w   $
��left=�6�   $��	5,265,1,5q�5K      �� 5L      $��Choose Parcel��6   ���#DFDFDF$��14(�6L   $��0��6Z   $��1��6g   $��25��6w   $��Bottom=�6�   $	��137��5M      $��	48,50,1,5q�6   5N      5P      5Q      5S      5T      