   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizTimeQuizTime  5   	        QuizTime.quizQuestionsGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuizTime     5   	     � Title$  quizQuestionsGrid��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� -   5        $��TextBlockHeading��5
   P   $��32��6   $
��Left=�6    $��10,10,0,378q�6;   $��Vragen��6h   $��18(�6v   � 5   
   -   5         �Name$ 
gQuestions��5      $
��Left=�6#   $	��363��6>   $��	10,47,0,0q�6K   $	��Top=�6^   $	��774��6v    � ColumnDefinitions 5      �� 5      $
��443* �6#   �� 5      $	��18* �6#   �� 5      $
��313* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgQuestions��5         AutoGenerateColumns .  $
��Left=�6H   $   HorizontalScrollBarVisibility$ Disabled=�6c   $	��321��5      $	��Top=�6$   $	��774��6<      CanUserResizeRows .     CanUserAddRows .  $��3��5   H   ��5   H   ��  �� Path$ LoadDataBinding�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 nummer��6N      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6^      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� $ question_id�6j     5      $

 naam��6Q   $	 150 6_    .  6)   �� $ quiz_questions�6k     5      $
 plaatje��6Q   $	 150 6b    .  6)   �� $ question_image�6n     5      $
 datum��6Q   $	 150 6`    .  6)   �� $ questions_date�6l   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 75 6-      CellTemplate 5      �� 5      .R�5   "   �� -   5        $
��Edit��5   )   68   5      5        5       $ 75 6-    5!      �� 5"      .R�5#   "   �� -   5        $��Delete��5#   )   6:   5$      5&      5(      �� 5)      -   5         ��Name$ btnAddQuestions��5)      $��voeg toe��6.   $
��Left=�6A   $	��Top=�6\   $��80��6t   $��231.8,326,0,0q�6   $��30��6�   $��2��6�   �� 5*      -   5        $ cancel��5*      $��	annuleren��6%   $
��Left=�69   $��
10,326,0,0q�6T   $	��Top=�6h   $��98��6�   $��30��6�   6�   5+      �� 5,   
   $��
Quiz naam:��6   $
��Left=�6%   $��
159,12,0,0q�6@   $	��Top=�6T   �� 5-   
   -   5         ��Name$ txbQuizname��5-      $
��Left=�6'   $��23��6B   $��
231,16,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5.   
   -	   5        $ btn_changeQuizName��5.      $��Verander quiz naam��6-   $
��Left=�6J   $��
376,16,0,0q�6e   $	��Top=�6y   $	��125��6�   $��23��6�   6�   5/      50      