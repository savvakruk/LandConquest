   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LandConquestLandConquest  5   	   &     LandConquest.AuthorisationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:LandConquest     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   [ WWPFLocalizeExtension, Version=3.8.0.0, Culture=neutral, PublicKeyToken=c726e0262981a1eb2lex(http://wpflocalizeextension.codeplex.com  5	   	   4  .WPFLocalizeExtension.Engine.LocalizeDictionary    DesignCulture$  en��5
   	      IncludeInvariantCulture .  =  7WPFLocalizeExtension.Providers.ResxLocalizationProvider   DefaultAssembly$ LandConquest��5   	      DefaultDictionary$ 	Resources��5   	    � Title$ Land Conquest��5   	   $	��500��6   $	��800��6,   $	��500��68   $	��800��6H   $	��500��6W   $	��800��6g   $��Palatino Linotype)�6v   .��5      � .+�5   
   �� -   5         ��Name$ loginGui��5      $
��Left=�6"   $	��285��6=   $��	555,6,0,0q�6J   $	��Top=�6^   $	��215��6v   $4��./LandConquest;component/Pictures/login_gui.png��6�   �� 5   
   -   5        $ registerGui��5      $
��Left=�6%   $	��414��6@   $��19,3,0,0q�6M   $	��Top=�6_   $	��252��6w   $7��1/LandConquest;component/Pictures/register_gui.png��6�   �� 5   
   -   5         ��Name$ textBoxLogin��5      $��587,105,53.6,0q�6(    �� TextWrapping$
 Wrap=�6@   $�� ��6T   .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�6r   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	  Login��5      
   
IsFloating
 .     UnderlineBrush
 ����  �� 
CaretBrush
 �   �$��25��6�   $	��Top=�6�   ��5   \   Z�  �� SelectionBrush 5   �   Z� ��6�   Z� G� 5   
   -   5         G�Name$ textBoxPass��5      $��587,157,53.6,0q�6+   $ Hidden=�6Y   
 ���� $	 	 Password��5      
 .  $��27��6o   $	��Top=�6{    G� 
CaretBrush
 �   ���5   C   Z�  G� SelectionBrush 5   �   Z� ��6�   Z� �� 5    
   -   5         ��Name$ buttonLogin��5       $�� ��6'   $
��Thin"�62   $��24(�6D   
��� ���$��
Harrington)�6i   $��628,241,96.6,192.4q�6�   $��Center=�6�   $��37��6�   $��0q�6�   
������� J� RenderTransformOrigin$ 	0.501,0.5&�6  ��6  Z� 6  �� 5"   
   -   5        $ textBoxNewLogin��5"      $
 Wrap=�6+   $�� ��6?   $��50,112,0,320.4q�6G   $ Hidden=�6_   
 ���� $	 
 New login��5#   ,   
 �   �$
��Left=�6k   $	��175��6�   $��0q�6�    �� SelectionOpacity$ 0Q�6�   ��6   Z�  6�   Z� ��6�   Z� 6�   �� 5$   
   -   5        $ textBoxNewEmail��5$      $
��Left=�6+   $
 Wrap=�6F   $�� ��6Z   $	��175��6b   $��50,172,0,262.4q�6n   $ Hidden=�6�   
 ���� $	  Email��5%   ,   
 �   �$��0q�6�   $ 0Q�6�   ��6   Z�  6i   Z� ��6�   Z� 6�   �� 5&   
   -   5        $ textBoxNewPass��5&      $
��Left=�6*   $
 Wrap=�6E   $�� ��6Y   $	��175��6a   $��50,237,0,198.4q�6m   $ Hidden=�6�   
 ���� $	  New password��5'   ,   
 �   �$��0q�6�   $ 0Q�6�   ��6   Z�  6o   Z� ��6�   Z� 6�   �� 5(   
   -	   5        $ textBoxConfirmNewPass��5(      $
��Left=�61   $��33��6L   $��
50,304,0,0q�6X   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��175��6�   $ Hidden=�6�   
 ���� $	  Confirm password��5)   ,   
 �   �$��0q�6�   $ 0Q�6�   ��6   Z�  6s   Z� ��6�   Z� 6�   �� 5+   
   -
   5        $ buttonRegistrate��5+      $�� ��6+   $
��Thin"�66   $��24(�6H   
��� ���$��
Harrington)�6m   $��63,376,657.6,52.4q�6�   $
��Auto��6�   $��0q�6�   ��6�   Z� �� 5,   
   -   5        $ buttonCancelRegistrate��5,      $�� ��61   $
��Left=�6<   $��154,376,0,0q�6W   $	��Top=�6l   $��71��6�   $��41��6�   ��6�   Z� ��6�   Z� ��6�   Z� 6�   �� 5/   
   -   5         ��Name$ CheckboxRemember��5/      $
��Left=�6.   $��703,200,0,0q�6I   $	��Top=�6^   $ 0.5,0.5&�6v   $��15��6�   
���   � d� 	IsChecked$
 TrueY�6�   $��1q�6�   ���	#FFB4A500$��15��6�    � Cursor$
 Hand��6�   �� 51   
   -   5        $ buttonShowRegistration��51      $��Button��61   $
��Left=�6B   $��	53,18,0,0q�6]   $	��Top=�6p   $	��167��6�   $��46��6�   $ 0.5,0.5&�6�   ��6�   Z� ��6�   Z� z�52      V� 53      .~�54      �� �� 55       �� AngleY$ 0.083Q�6$   �� 56      T� 57       T� Y$ 0.124Q�6)   58      ��5:      �� 5;       �� ImageSource$7 1/LandConquest;component/Pictures/register_btn.png��6   5=      �� 5?   
   -   5         ��Name$ LocLabelCurrentOnline��5?      $��Trebuchet MS)�6`   $��20(�6z   $��SemiBold"�6�   $��280,14,316.6,424.4q�6�   ���	#FF7B3501��64   2  ,WPFLocalizeExtension.Extensions.LocExtension  *LocLabelCurrentOnline_Text+6�   �� 5A   
   -   5         ��Name$ currentOnlineLabel��5A      $��0��6,   $��Trebuchet MS)�68   $��20(�6R   $��SemiBold"�6`   $��448,11,241.6,413.4q�6v   ���	#FF7B35016�   �� 5B   
   -   5        $ labelGameFiles��5B      $��Checking game files...��6(   $��Trebuchet MS)�6I   $��22(�6c   $��SemiBold"�6q   $��515,416,9.6,10.4q�6�   ���	#FFCA691E6�   �� 5C   
   -   5        $ iconDownload��5C   4   $ ��/Pictures/downloadicon.png��6   $
 Hand��6J   $��469,410,274.6,10.4q�6{   �� 5D   
   $H��BPlease send us any comment, suggestion or correction you may have!��6   
�������$��Trebuchet MS)�6w   $
��Left=�6�   $��
19,417,0,0q�6�   $	��Top=�6�   $	��390��6�   �� 5F   
   -   5        $ labelNameValid��5F      $��Error in name!��6(   $��Book Antiqua)�6A   $��16(�6[   $��SemiBold"�6i   $��260,114,243.6,320.4q�6   
���  ��6�   �� 5G   
   -   5        $ labelEmailValid��5G      $��Error in email!��6)   $��Book Antiqua)�6C   $��16(�6]   $��SemiBold"�6k   $��260,172,243.6,262.4q�6�   
���  ��6�   �� 5H   
   -   5        $ labelPassValid��5H      $��Error in password!��6(   $��Book Antiqua)�6E   $��16(�6_   $��SemiBold"�6m   $��260,241,243.6,192.4q�6�   
���  ����6�   Z� �� 5I   
   -   5        $ labelConfirmPassValid��5I      $��Passwords do not match!��6/   $��Book Antiqua)�6Q   $��16(�6k   $��SemiBold"�6y   $��260,304,241.6,133.4q�6�   
���  ��6�   �� 5K   
   -   5        $ labelAgreement��5K      $��Center=�6(   ���	#FFE5DE0A$��14(�6c   $��Tahoma)�6q   $
��Left=�6�   $��
50,334,0,0q�6�   $	��Top=�6�   $	��175��6�   $
 Hand��6�   ��6�   Z� .��5L      �� $��	Underline{�6   $��Center=�64   $��Trebuchet MS)�6Q   User agreement6{   5M      �� 5O   
   $$��landconquestofficial@gmail.com��6   
�������$��Trebuchet MS)�6R   $��22,442,568.6,-0.6q�6l   ��6�   Z� .��6�   ��5P      �� 5Q       �� 
TargetType" ��6   .�5R      ��  �� Property �@��
IsReadOnly �� Value . 63   �� 5S       � ��$ 0q�68   �� 5T       �@��TextWrapping$
 Wrap=�65   5U      .��5V      5W      ��5Y   
   �� 5Z      $, &/Pictures/authorisation_background.png��6    j� Stretch$ UniformToFill=�6N   5\      5^      