   M S B A M L   `   `   `  ����C  ?QuizTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:QuizTimeQuizTime  5   	       QuizTime.quizAddAnswers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:QuizTime     5   	     � Title$  quizAddAnswers��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   � -   5         �Name$ quizAnswersGrid��5
      $
��Left=�6(   $	��175��6C   $��
158,94,0,0q�6P   $	��Top=�6d   $	��482��6|    � ColumnDefinitions 5      �� 5      $
��145* �6#   �� 5      $	��96* �6#   .+�5      �� -   5         ��Name$ 
txbAnswerA��5      $
��Left=�6*   $��22��6E   $��
181,27,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��144��6�   $��2��6�   �� 5      $��
Antwoorden��6   $
��Left=�6)   $��	10,-1,0,0q�6D   $	��Top=�6W   $
��Bold"�6o   �� 5      -   5        $ 
txbAnswerB��5      $
��Left=�6*   $��22��6E   $��
181,67,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��144��6�   $��2��6�   �� 5      -   5        $ 
txbAnswerC��5      $
��Left=�6*   $��22��6E   $��181,104,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��144��6�   $��2��6�   �� 5      -   5        $ 
txbAnswerD��5      $
��Left=�6*   $��23��6E   $��181,143,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��144��6�   $��2��6�   �� 5      -   5         ��Name$ 	cbAnswerA��5      $
��Left=�6*   $��58.2,28,0,0q�6E   $	��Top=�6Z   $	��120��6r    �� SelectedIndex$ 0��6~   $��1��6�   .@�5      �� $��fout antwoord��6   �� 5      $��goed antwoord��6   5      �� 5      -   5        $ 	cbAnswerB��5      $
��Left=�6*   $��58.2,65,0,0q�6E   $	��Top=�6Z   $	��120��6r   $ 0��6~   $��1��6�   .@�5      �� $��fout antwoord��6   �� 5      $��goed antwoord��6   5      �� 5      -   5        $ 	cbAnswerC��5      $
��Left=�6*   $��58.2,104,0,0q�6E   $	��Top=�6[   $	��120��6s   $ 0��6   $��1��6�   .@�5      �� $��fout antwoord��6   �� 5      $��goed antwoord��6   5      �� 5       -	   5        $ 	cbAnswerD��5       $
��Left=�6*   $��58.2,143,0,0q�6E   $	��Top=�6[   $	��120��6s   $ 0��6   $��1��6�   .@�5!      �� $��fout antwoord��6   �� 5"      $��goed antwoord��6   5#      �� 5$      $��Vul hier antwoord A in:��6   $
��Left=�66   $��	10,25,0,0q�6Q   $	��Top=�6d   �� 5%      $��Vul hier antwoord B in:��6   $
��Left=�66   $��	10,63,0,0q�6Q   $	��Top=�6d   �� 5&      $��Vul hier antwoord C in:��6   $
��Left=�66   $��
10,100,0,0q�6Q   $	��Top=�6e   �� 5'      $��Vul hier antwoord D in:��6   $
��Left=�66   $��
10,140,0,0q�6Q   $	��Top=�6e   5(      �� 5)   
   -
   5         ��Name$ cancelAnswer��5)      $��cancel��6'   $
��Left=�68   $��
10,377,0,0q�6S   $	��Top=�6g   $��81��6   $��33��6�   6�   �� 5*   
   -   5        $ 	addAnswer��5*      $��voeg toe��6$   $
��Left=�67   $��698,377,0,0q�6R   $	��Top=�6g   $��86��6   $��33��6�   6�   5+      5,      