   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizTimeQuizTime  5   	       QuizTime.quizGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuizTime     5   	     � Title$  quizGrid��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   �� -   5        $��TextBlockHeading��5
   P   $��32��6   $
��Left=�6    $��10,10,0,378q�6;   $��Quizzen��6h   $��18(�6w   � 5   
   -   5         �Name$ gQuiz��5      $
��Left=�6   $	��363��69   $��	10,47,0,0q�6F   $	��Top=�6Y   $	��774��6q   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgQuiz��5         AutoGenerateColumns .  $
��Left=�6C   $   HorizontalScrollBarVisibility$ Disabled=�6^   $	��321��5      $	��Top=�6$   $	��774��6<      CanUserResizeRows .     CanUserAddRows .  ��6H   ��  �� Path$ LoadDataBinding�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 nummer��6J   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6Z      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� $ quiz_id�6f     5      $
	 naam��6L   $	
 150 6Z    .  6)   �� $ 	quiz_name�6f     5      $	 datum��6L   $	
 150 6[    .  6)   �� $ 	quiz_date�6g   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 75 6-      CellTemplate 5      �� 5      .R�5   "   �� -   5        $
��Edit��5   )   68   5      5        5      $
 75 6-    5      �� 5      .R�5   "   �� -   5        $��Delete��5   )   6:   5      5       5"      �� 5#      -   5         ��Name$ 
btnAddQuiz��5#      $��voeg toe��6)   $
��Left=�6<   $	��Top=�6W   $��80��6o   $��693,326,0,0q�6z   $��30��6�   6�   �� 5$      -   5        $ cancel��5$      $��	annuleren��6%   $
��Left=�69   $��
10,326,0,0q�6T   $	��Top=�6h   $��98��6�   $��30��6�   6�   5%      5&      5'      