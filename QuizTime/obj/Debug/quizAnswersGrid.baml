   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizTimeQuizTime  5   	       QuizTime.quizAnswersGrid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuizTime     5   	     � Title$  quizAnswersGrid��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5        $��TextBlockHeading��5
   P   $��32��6   $
��Left=�6    $��10,10,0,378q�6;   $��
Antwoorden��6h   $��18(�6z   � 5   
   -   5         �Name$ gAnswers��5      $
��Left=�6!   $	��272��6<   $��	10,85,0,0q�6I   $	��Top=�6\   $	��774��6t    � ColumnDefinitions 5      �� 5      $��7* �6#   �� 5      $��2* �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgAnswers��5         AutoGenerateColumns .  $
��Left=�6F   $   HorizontalScrollBarVisibility$ Disabled=�6a   $	��272��5      $	��Top=�6$   $	��774��6<      CanUserResizeRows .     CanUserAddRows .  $��2��5   H   ��5   H   ��  �� Path$ LoadDataBinding�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 nummer��6M      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6]      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� $ 
answers_id�6i     5      $
 
antwoorden��6J   $	 150 6^    .  6)   �� $ answers�6j     5      $
 goed antwoord��6O   $	 150 6f    .  6)   �� $ right_answer�6r     5      $
 datum��6O   $	 150 6^    .  6)   �� $ answers_date�6j   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 75 6-      CellTemplate 5      �� 5      .R�5   "   �� -   5        $
��Edit��5   )   68   5      5        5      $ 75 6-    5       �� 5!      .R�5"   "   �� -   5        $��Delete��5"   )   6:   5#      5%      5'      5(      �� 5)   
   $��Vraag:��6   $
��Left=�6!   $��
159,12,0,0q�6<   $	��Top=�6P   �� 5*   
   -   5         ��Name$ txbQuestion��5*      $
��Left=�6'   $��23��6B   $��
231,16,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5+   
   -   5         ��Name$ btn_changeQuizName��5+      $��Verander vraag��6-   $
��Left=�6F   $��
376,16,0,0q�6a   $	��Top=�6u   $	��125��6�   $��23��6�   6�   �� 5,   
   -   5        $ btnChangeImage��5,      $��plaatje veranderen��6)   $
��Left=�6F   $��
675,16,0,0q�6a   $	��Top=�6u   $	��109��6�   $��23��6�   6�   �� 5-   
   -	   5         ��Name$ questionImage��5-      $
��Left=�6'   $��70��6B   $��
557,10,0,0q�6N   $	��Top=�6b   $��85��6z   �� 5.   
   -
   5        $ cancel��5.      $��	annuleren��6!   $
��Left=�65   $��
10,380,0,0q�6P   $	��Top=�6d   $��98��6|   $��30��6�   6�   �� 5/   
   -   5        $ btnAddAnswers��5/      $��voegtoe��6(   $
��Left=�6:   $	��Top=�6U   $��80��6m   $��704,380,0,0q�6x   $��30��6�   6�   50      51      