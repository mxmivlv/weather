   M S B A M L   `   `   `  ����D  @Module_10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Module_10	Module_10  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Module_10.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Module_10     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   0sys&clr-namespace:System;assembly=mscorlib  5   	     � Title$  Weather��5   	   $	��400��5   	   $	��450��5   	    � 	Resources 5      �� 5   
      KeyCity   �� Type" ��6   .s�5      ��Irkutsk��6"   ��5      
Moscow��6!   ��5      Novosibirsk��6&   ��5      Saint Petersburg��6+   ��5      
Samara��6!   ��5      Saransk��6"   ��5      Saratov��6"   ��5      
Samara��6!   ��5      Irkutsk��6"   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��109* �6   �� 5      $	��19* �6    � ColumnDefinitions 5    
   �� 5!      $	��64* �6   �� 5"      $	��61* �6   .+�5%   
   �� -   5         ��Name$ DataAndTime��5%      $��1��5&      $��
Your city:��5'      $��	5,28,50,0q�5(      $	��Top=�5)      $��27��5*      $��15(�5+      $��Times New Roman)�5,      �� 5.   
   -   5         ��Name$ ComboBoxCity��5.      $��1��5/      $��5,60,5,0q�50      $	��Top=�51        City#��[ 52      $��25��53      $��Times New Roman)�55      $��15(�56      �� 58   
   -   5        $��1��58      $��Show the weather��59      $��5,5,5,5q�5:      $��1��5;      $��Times New Roman)�5=      $��15(�5>      �� 5A   
   -   5         ��Name$ Water_Messages��5A      $��5,5,5,0q�5B      $��Times New Roman)�5C      $��15(�5D      ��5E      �� 5F      .R�5G      �� 
�������$��1q�60   $	��170��6D   $��70��6P   ._�5H      �� .+�5I      �� $��City: ��6(   
���   �$��15(�6I   �� 6X   
���   �$��15(�6�   ��6b   ��  �� Path$ NameCity�6�   6�   �� 5J      $��Temperature: ��6(   
���   �$��15(�6P   �� 6_   
���   �$��15(�6�   ��6i   �� $ TempCity�6�   6�   �� 5K      $��Min.temperature: ��6(   
���   �$��13(�6T   �� 6c   
���   �$��13(�6�   ��6m   �� $ MinTempCity�6�   6�   �� 5L      $��Max.temperature: ��6(   
���   �$��13(�6T   �� 6c   
���   �$��13(�6�   ��6m   �� $ MaxTempCity�6�   6�   5M      5N      5O      5Q      5R      5S      