   M S B A M L   `   `   `  ����Q  MAplicatieContabilitate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AplicatieContabilitateAplicatieContabilitate  5   	   +    %AplicatieContabilitate.ViewCheltuieli   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:AplicatieContabilitate     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   $	��600��5      $
��1024��6(     � 
ResizeMode$  NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K    � WindowStyle$
 None=�6p   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ GridBarTitle��5      $��2��6%   ���	#FFE78C11 5      �� 5      $
��277* �6#   �� 5      $
��120* �6#   .+�5      �� $��
Cheltuieli��6   $
��Left=�6*   $��Segoe UI Black)�6E   $��16(�6a   
�������$	��108��6�   $��18,0,0,-0.6q�6�   6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�62   $��	0,0,9.6,0q�6N   $��1��6a   .+�5      �� -   5         ��Name$ CloseButton��5      $��25��6.   $��25��69   
���������6E   Z� ��6[   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6.   $��20��6;   $��20��6G   5      5      5      � 5   
   $��2��6   $��1��6   .+�5       �� $��
0,0,0,-0.4q�6   .��5!      �  5"      �� 5#      �� 5$       5&      �� 5'      $
��200* �6(   �� 5(      $
��200* �6(   .+�5+      � $��0��6   $��0,0,0,247.6q�6+   $��2��6@   .+�5,      �� $��30,42,30,-2q�6$   ���	#FFEBEBEB	 �� RadiusY$	 10��6J   
 �� RadiusX$
 10��6W    J� RenderTransformOrigin$ 0.5,0.5&�6d   z�5-      V� 5.   "   .~�5/   &   �� �� 50   &    �� AngleX$ -0.293Q�64   �� 51   &   T� 52   &    T� X$ -0.595Q�69   53   #   55      � 56      $��25,30q�6   .+�57      � $��30��6#   ���	#FFF7A638$��40��6E   $	��Top=�6Q   $
��Left=�6i   $��	30,12,0,0q�6�   .+�58   "     $ DecimalDecrease=�6:   $��Center=�6Q   $��Center=�6n   
�������$��35��6�   $��35��6�   59      �� 5:      $��Alege un punct��6(   $��167,57,150,174.6q�6>   $��Arial)�6X   $��20(�6k   (  "System.Windows.Controls.DatePicker  5;      -   5        $��
datePicker��5;   i   $��30��6)   $��Center=�65   $��167,169,172,0q�6R   $	��Top=�6�   $	��115��6�   �� 5<      -   5        $��	ComboBox1��5<   '   $��Arial)�6f   $��127,92,122,139.6q�6y   .@�5=   "   �� $��Punct 1��6/   6C   �� 5>   "   $��Punct 2��6/   6C   �� 5?   "   $��Punct 3��6/   6C   �� 5@   "   $��Punct 4��6/   6C   �� 5A   "   $��Punct 5��6/   6C   �� 5B   "   $��Punct 6��6/   6C   5C      5D      5E      � 5F      $��1��6   .+�5G      �� $��30,42,30.2,227.6q�6$   ���	#FFEBEBEB$	 10��6O   $
 10��6\   � 5H      $��25,30q�6   .+�5I      �� -   5        $��lvPoints��5I   (   $��Center=�68   $��Center=�6U   $	��161��6p   $	��269��6~   $��101,72,83.2,260.6q�6�    �� View 5J   "   �� 5K   &   .P�5L   *   �� $��Id��69    �� Width$ 50��6E   -   5        ID�� �� DisplayMemberBinding 5L   \   �� *Id+�� 5M   *   $
��Data��69   $ 67��6G    6R   �� *Date+�� 5N   *   $��
Cheltuieli��69   $	 150��6M    6Y   �� *
Cheltuieli+5O   '   5Q      5R      5S      5T      5V      5W      5X      5Y      