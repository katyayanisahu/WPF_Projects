   M S B A M L   `   `   `  ����`  \ArcGIS.Desktop.Framework, Version=13.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86wQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework!ArcGIS.Desktop.Framework.Controls  5   	   a ]ArcGIS.Desktop.Extensions, Version=13.0.0.0, Culture=neutral, PublicKeyToken=8fc3cc631e44ad86hJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.ExtensionsArcGIS.Desktop.Extensions 5   	    AllocateNonMappedParcel-   'AllocateNonMappedParcel.NonMappedParcel   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   fcontrolsQclr-namespace:ArcGIS.Desktop.Framework.Controls;assembly=ArcGIS.Desktop.Framework     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   a
extensionsJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.Extensions     5   	     � Title$  Move Non-Mapped Parcels��5	   	   $	��380��6)   $	��380��66   ���#F2F2F2 � WindowStartupLocation$ CenterOwner=�5
   	    � 	Resources 5       �� MergedDictionaries<  6ArcGIS.Desktop.Extensions.DesignOnlyResourceDictionary   Source�� 5   
    5        5      $S Mpack://application:,,,/ArcGIS.Desktop.Framework;component\Themes\Default.xaml?�6:   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,    � ColumnDefinitions 5   
   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   .+�5'   
   �� -   5        $��Label1��5'      $��Selected Parcel 1��6   $	��120��6:   $��0��6F   $��	15,15,1,5q�6S   $��0��6f   $��30��6v    �� Left$ 10��6�   
 �� Top$ 10��6�   $��13(�6�   $��Segoe UI)�6�   $
��Bold"�6�   
���   �6�   �� 5)   
   -   5        $��Label2��5)      $��Selected Parcel 2��6   $	��120��6:   $��0��6F   $��0,15,1,5q�6S   $��2��6e   $��30��6u   $ 10��6�   $ 10��6�   $��13(�6�   $��Segoe UI)�6�   $
��Bold"�6�   
���   �6�   �� 5,   
   $��Flash��6   $	��120��6!   $��25��6-   $��Segoe UI)�69   $��1��6O   $��14(�6]   ���#DFDFDF$��0��6�   $
��left=�6�   $��	15,0,1,15q�5-      �� 50   
   $��Flash��6   ���#DFDFDF$��14(�68   $��Segoe UI)�6G   $��1��6]   $��2��6j   $��25��6z   $��Right=�6�   $	��120��51      $��0,0,1,15q�6   �� 54   
   -   5        	 ��Name$	 listBox1��54      $��15,0,1,5q�6$   $��2��66   $��0��6C   $
��Left=�6S   $	��Top=�6n   $	��120��6�   $	��225��6�   ��6�   �� *Names+��56      �� 57      .R�58      �� .+�59      �� �� 5:   %   �6)   �� *REID+5<      5>      5?      5A      �� 5B   
   -   5        $	 listBox2��5B      $��0,0,1,5q�6$   $��2��65   $��2��6B   $��Right=�6R   $	��Top=�6n   $	��120��6�   $	��225��6�   �� 5E   
   $��<��6   $��50��6!   $��3q�6,   $��25��68   $��2��6D   $��14(�6Q   ${�False��6_   $	��Top=�6q   ���#DFDFDF$��1��6�   $��
25,30,20,0q�5F      �� 5H   
   $��>��6   $��50��6"   $��25��6-   $��3��69   $��14(�6F   $	��Top=�6T   ${�False��6l   ���#DFDFDF$��1��6�   $��25,-160,20,0q�5I      �� 5K   
   $��<<��6   $��50��6$   $��25��6/   $��4��6;   $��14(�6H   $	��Top=�6V   ${�False��6n   ���#DFDFDF$��1��6�   $��25,-120,20,0q�5L      �� 5N   
   $��>>��6   $��50��6$   $��25��6/   $��5��6;   $��14(�6H   $
��Bold"�6V   $	��Top=�6i   $��1��6�   $��25,-75,20,0q�5O      ���#F2F2F26(   5Q      5R      