   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizTimeQuizTime  5   	       QuizTime.selection   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuizTime     5   	     � Title$  	selection��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgQuiz��5
         AutoGenerateColumns .  $
��Left=�6?   $   HorizontalScrollBarVisibility$ Disabled=�6Z   $	��291��5      $	��Top=�6$   $	��794��6<      CanUserResizeRows .     CanUserAddRows .  $��0,56,-0.4,0q�5   H   ��5   H   ��  �� Path$ LoadDataBinding�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ nummer��6F   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6V   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� $ quiz_id�6`     5      $
 naam��6H   $	 * 6V   
 .  6%   �� $ 	quiz_name�6`     5      $ datum��6H   $	 * 6W   
 .  6%   �� $ 	quiz_date�6a   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 * 6)      CellTemplate 5      �� 5      .R�5      ��  ��Name$ btnStart��6%   -   5        $��start��5   7   6G   5      5        5      $	 * 6)    5      �� 5      .R�5      �� $ btnCheckAnwsers��6%   -   5        $��Check antwoorden��5   >   6Y   5      5      5       �� 5!   
   -   5        $ btnBack��5!      $��terug��6"   $
��Left=�62   $��
38,366,0,0q�6M   $	��Top=�6a   $��96��6y   $��36��6�   6�   5"      5#      