   M S B A M L   `   `   `  ����Q  MMyDashboardApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MyDashboardApplication.ViewsMyDashboardApplication.Views  5   	   -    'MyDashboardApplication.Views.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   6local*clr-namespace:MyDashboardApplication.Views  5   	     [� ShowsNavigationUI$  False��5	       � Title$ Library Management��5
   	   $	��962��6$   $
��1789��61    � WindowState$ 	Maximized=�6>    � WindowStartupLocation$ CenterScreen=�6V   ��5      � 5   
    � ColumnDefinitions 5      �� 5      $��0.25* �6#   �� 5      .+�5      � $��0��6   ���#f77902.+�5      �� .+�5      �� $��20 0 0 0q�6    $��Library��62   $��40(�6A   $��Medium"�6O   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Database=�6.   $	��100��6>   $	��100��6K   5      �� 5      $��20 0 0 0q�6    $��
Management��62   $��40(�6D   $��Medium"�6R   �� 5      $��Tables��6    $��	20 60 0 0q�6.   $��40(�6A   $��Medium"�6O   �� 5      -   5        $��TablesCB��5      
�������$��50��6C   $��
10 10 10 0q�6O   ��6c   �� *
TableNames+5      �� 5!      -   5        $��
AddDataBTN��5"      
���   �   MaterialDesignRaisedButton#��[  5$      $��60��5%      $��10 100 10 0q�5&      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5(       � ToolTip$3 -MaterialDesignRaisedButton with Round Corners��5)      {�5*      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+	 �� AncestorType
	 Window.��5,      �� 
 �� Orientation$
 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5-        $
 Plus=�67   $��Center=�6C   $��30��6^   $��30��6i   $��0 0 10 0q�6u   �� 5.      $��Add Data��6(   $��20(�68   5/      50      �� 54      #��[  55      $��60��56      $��
10 10 10 0q�57      
���   �$ 10��5:      $3 -MaterialDesignRaisedButton with Round Corners��5;      {�5<      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
	 Window.��5>      �� $
 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5?        $ Update=�66   $��30��6D   $��30��6O   $��0 0 10 0q�6[   �� 5@      $��Update Data��6(   $��20(�6;   5A      5B      �� 5E      #��[  5F      $��60��5G      $��
10 10 10 0q�5H      
���   �$ 10��5K      $3 -MaterialDesignRaisedButton with Round Corners��5L      {�5M      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
	 Window.��5O      �� $
 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5P        $ Delete=�66   $��30��6D   $��30��6O   $��0 0 10 0q�6[   �� 5Q      $��Delete Data��6(   $��20(�6;   5R      5S      �� 5U      #��[  5V      $��60��5W      $��
10 10 10 0q�5X      
���   �$ 10��5[      $3 -MaterialDesignRaisedButton with Round Corners��5\      {�5]      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
	 Window.��5_      �� $
 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5`        $ DatabaseSearch=�66   $��30��6L   $��30��6W   $��0 0 10 0q�6c   �� 5a      $��Search Data��6(   $��20(�6;   5b      5c      �� 5e      #��[  5f      $��60��5g      $��
10 10 10 0q�5h      
���   �$ 10��5k      $3 -MaterialDesignRaisedButton with Round Corners��5l      {�5m      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
	 Window.��5o      �� $
 
Horizontal=�6%   $��Center=�6>   $��Center=�6[   .+�5p        $ DatabaseArrowDown=�66   $��30��6P   $��30��6[   $��0 0 10 0q�6g   �� 5q      $��Get Data��6(   $��20(�68   5r      5s      5u      5v      � 5z      $��1��6   .+�5{       �   � Source$2 ,\Views\InsertPages\InsertAuthorPageView.xaml?�6   5|      5~      5�      