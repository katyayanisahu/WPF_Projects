   M S B A M L   `   `   `  ����`  \ArcGIS.Desktop.Framework, Version=13.1.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86wQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework!ArcGIS.Desktop.Framework.Controls  5   	   A =DemoLB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DemoLBDemoLB 5      a ]ArcGIS.Desktop.Extensions, Version=13.1.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86hJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.ExtensionsArcGIS.Desktop.Extensions 5   	      DemoLB.ListItems   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   fcontrolsQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #uiclr-namespace:DemoLB     5      a
extensionsJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.Extensions     5   	     � Title$  Select Parcel��5   	   $	��350��6   $	��330��6,    � WindowStartupLocation$ CenterOwner=�5   	    � 	Resources 5       �� MergedDictionaries<  6ArcGIS.Desktop.Extensions.DesignOnlyResourceDictionary   Source�� 5   
    5        5      $S Mpack://application:,,,/ArcGIS.Desktop.Framework;component\Themes\Default.xaml?�6:   %    5      .��5      �� $
��Auto=�6   .��5   
   � $��
0,0,4,-0.2q�6   .+�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5      �� -   5         ��Name$ listBox��5      $	��250��6+   $	��310��68   $��0��6D   $��0,10,5,0q�6Q   ��6c   �� *NamesCollection+��5       �� 5!      .R�5"      �� .+�5#   "   �� �� 5$   %   �6)   �� *REID+ �� 5%   %   �6)   �� *PIN+5&   #   5,      5-      50      52      � 53   
    54      �� 55      $
��auto �6    60   �� 56      $
��auto �6    60   �� 57      $
��auto �6    60    � ColumnDefinitions 5:      �� 5<      $
��auto �6#   �� 5=      $
��auto �6#   �� 5>      $
��auto �6#   �� 5?      $
��auto �6#   �� 5@      $
��auto �6#   �� 5A      $
��auto �6#   �� 5B      $
��auto �6#   �� 5C      $
��auto �6#   .+�5G      �� $��Cancel��6   $	��120��6&   $��25��62   $��0��6>   $��14(�6L   ���#DFDFDF$��0��6o   $
��left=�6   $��	5,265,1,5q�5H      �� 5I      $��Choose Parcel��6   ���#DFDFDF$��14(�6D   $��0��6R   $��1��6_   $��25��6o   $��Bottom=�6{   $	��137��5J      $��	48,50,1,5q�6   5K      5M      5N      5O      