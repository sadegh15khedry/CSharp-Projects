   M S B A M L   `   `   `  ����F  BWpfLearning, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfLearningWpfLearning  5   	       WpfLearning.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfLearning     5   	   $��18(�5        � Title$  Login��5   	      WindowDefaultStyle#��[  6   .��5
      � -   5        $��myGrid��5
       � ShowGridLines$ False��6   $��0 0 15 0q�6/    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��50(�6   $
��Bold"�6"   $��0��5      $��Stretch=�6    �� TextAlignment$ Center=�5      $��Center=�5      $
��0 80q�6(   Welcome to Shop Manager!5      �� 5   
   $��Center=�6   $��0 0 0 20q�5       �� Orientation$ 
Horizontal=�5       $��1��6.   .+�5!      �� $��Microsoft Sans Serif)�6   ���#FFFF.��6I   	Email :5#      �� 5$      $	��250��6   5%      �� 5&   
   $��	0 0 30 10q�6   $��2��6(   $ 
Horizontal=�65   $��Center=�6N   .+�5'      �� $��Microsoft Sans Serif)�6   ���#FFFF.��6I   	Password:5)      G� 5*      $	��250��6   5+      �� 5,   
   $��3��6   $��Stretch=�6!   $ Center=�5-      Forgot password? click here !5/      �� 50   
   -   5        $��LoginButton��51   1   $	��180��50      $��50��6   $��4��6)   $��Center=�51   D   $��
50 30 0 30q�52      .��6&   Login54      �� 55   
   $��5��6   $��0��6!   $��Stretch=�61   $ Center=�56      Don't have an account?? �� 59      -   5        $��ToSignupButton��59        LinkTypeButtonStyle#��[ 5:      ���#FFFF.��6Q   	Sign up5<      5?      5B      5C      