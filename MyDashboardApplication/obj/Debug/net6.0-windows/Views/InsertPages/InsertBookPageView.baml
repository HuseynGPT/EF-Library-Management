   M S B A M L   `   `   `  ����Q  MMyDashboardApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:MyDashboardApplication.Views.InsertPages(MyDashboardApplication.Views.InsertPages  5      A    ;MyDashboardApplication.Views.InsertPages.InsertBookPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Blocal6clr-namespace:MyDashboardApplication.Views.InsertPages  5        N� Title$  InsertBookPageView��5	      $	��372��6"   $	��592��6/   .��5      � 
�������.+�5   
   �� $
��Left=�6   $��	25,42,0,0q�6/   $
��Wrap=�6B   $��Name	��6V   $	��Top=�6g   �� 5   
   $
��Left=�6   $��	86,38,0,0q�6-    �� TextWrapping$
 Wrap=�6@   $	��Top=�6k   $	��120��6�   ��6U   �� *Name+6�   �� 5   
   $
��Left=�6   $��	24,87,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   �� 6o   $�Pages��6s   �� 6�   �� 6�   6�   �� 5   
   -   5         ��Name$ PagesTB��5   *   $
��Left=�6;   $��	86,83,0,0q�6V   $
 Wrap=�6i   $	��Top=�6   $	��120��6�   ��6   �� *Pages+6�   �� 5   
   $
��Left=�6   $��
25,130,0,0q�6/   $
��Wrap=�6C   $��	YearPress��6W   $	��Top=�6h   �� 5   
   -   5        $ YearPressTB��5   .   $
��Left=�6C   $��
86,126,0,0q�6^   $
 Wrap=�6r   $	��Top=�6�   $	��120��6�   ��6   �� *	YearPress+6�   �� 5   
   $
��Left=�6   $��
24,171,0,0q�6/   $
��Wrap=�6C   $��IdTheme��6W   $	��Top=�6f   �� 5   
   -   5        $ 	IdThemeTB��5   -   $
��Left=�6@   $��
86,167,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   ��6   �� *
Id_Theme+6�   �� 5   
   -   5         ��Name$ ___No_Name_��5      $
��Left=�6)   $��
20,212,0,0q�6D   $
��Wrap=�6X   $��
IdCategory��6l   $	��Top=�6~   �� 5   
   -   5        $ IdCategoryTB��5   1   $
��Left=�6G   $��
86,208,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $	��120��6�   ��6   �� *Id_Category+6�   �� 5   
   $
��Left=�6   $��
24,251,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��IdAuthor��6o   �� 5   
   -   5        $ 
IdAuthorTB��5   .   $
��Left=�6B   $��
86,247,0,0q�6]   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   ��6   �� *	Id_Author+6�   �� 5   
   $
��Left=�6   $��
25,290,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   �� 6p   $�IdPress��6t   �� 6�   �� 6�   6�   �� 5   
   -   5        $ 	IdPressTB��5   -   $
��Left=�6@   $��
86,286,0,0q�6[   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   ��6   �� *
Id_Press+6�   �� 5   
   $
��Left=�6   $��
277,52,0,0q�6/   $
��Wrap=�6C   $��Comment��6W   $	��Top=�6f   �� 5   
   -   5        $ 	CommentTB��5   ,   $
��Left=�6?   $��
339,48,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��6   �� *	Comment+6�   �� 5   
   $
��Left=�6   $��
279,94,0,0q�6/   $
��Wrap=�6C   $��Quantity��6W   $	��Top=�6g   �� 5   
   -	   5        $ 
QuantityTB��5   -   $
��Left=�6A   $��
339,89,0,0q�6\   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   ��6   �� *
Quantity+6�   �� 5$       "  MaterialDesignRaisedDarkButton#��[  5%      $��50��5&      $��Insert��5'      $	��150��5(      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��5)       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5*      $��302,212,140,110q�5+   z   {�6   �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window��6�   �� *InsertCommand+5-      5/      50      