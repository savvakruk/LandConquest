   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:LandConquest.DialogWIndowsLandConquest.DialogWIndows  5   	   0    *LandConquest.DialogWIndows.SplitArmyDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:LandConquest.DialogWIndows     5   	     � Title$  SplitArmyDialog��5   	   $	��250��6!   $	��360��6.    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6    � ShowInTaskbar .  .��5      �� ���	#FF392018$��2q�6%   $	��250��69   $	��360��6F   ._�5   
   � .+�5   
   �� 	 �� X1$	 180��6   	 �� Y1$ 20��6   	 �� X2$	 180��6    	 �� Y2$	 230��6)   
���   �$��1��6A   6W   �� 5   
   $
��Left=�6   $��35��6+   $��	13,61,0,0q�67   $	��Top=�6J   $��35��6b   $��/Pictures/warrior.png��6m   �� 5   
   -   5         ��Name$ sliderInfantryWas��5      $
��Left=�6,   $��	48,78,0,0q�6G   $	��Top=�6Z   $	��114��6r   6�   �� 5   
   -   5        	 ��Name$	 infantryCountWas��5      $
��Left=�6y   $��	82,64,0,0q�6�   $	��Top=�6�   $��63��6�   ��6*   �� *Value+
 �� ElementName$
 sliderInfantryWas�� �� StringFormat$ {0:0}��6�   �� 5   
   $
��Left=�6   $��35��6+   $��
190,61,0,0q�67   $	��Top=�6K   $��35��6c   $2��,/LandConquest;component/Pictures/warrior.png��6n   �� 5   
   -   5        $ sliderInfantryNow��5      $
��Left=�6,   $��
225,78,0,0q�6G   $	��Top=�6[   $	��114��6s   6�   �� 5   
   -   5        $	 infantryCountNow��5      $
��Left=�6y   $��
259,64,0,0q�6�   $	��Top=�6�   $��63��6�   ��6*   �� *Value+$
 sliderInfantryNow��$ {0:0}��6�   �� 5   
   -   5        $��20��5      $��	337,0,0,0q�6   $	��Top=�60   $��20��6H   ��6h   Z� ��6   Z� ��5      �� 5       �� ImageSource$6 0/LandConquest;component/Pictures/buttonCross.jpg��6    j� Stretch$ Uniform=�6\   5      �� 5   
   $
��Left=�6   $��35��6+   $��	13,98,0,0q�67   $	��Top=�6J   $��35��6b   $1��+/LandConquest;component/Pictures/archer.png��6m   �� 5   
   -   5        $ sliderArchersWas��5      $
��Left=�6+   $��
48,115,0,0q�6F   $	��Top=�6Z   $	��114��6r   6�   �� 5   
   -   5        $	 archersCountWas��5      $
��Left=�6w   $��
82,101,0,0q�6�   $	��Top=�6�   $��63��6�   ��6)   �� *Value+$
 sliderArchersWas��$ {0:0}��6�   �� 5   
   $
��Left=�6   $��35��6+   $��
190,98,0,0q�67   $	��Top=�6K   $��35��6c   $1��+/LandConquest;component/Pictures/archer.png��6n   �� 5    
   -   5        $ sliderArchersNow��5       $
��Left=�6+   $��225,115,0,0q�6F   $	��Top=�6[   $	��114��6s   6�   �� 5!   
   -	   5        $	 archersCountNow��5!      $
��Left=�6w   $��259,101,0,0q�6�   $	��Top=�6�   $��63��6�   ��6)   �� *Value+$
 sliderArchersNow��$ {0:0}��6�   �� 5"   
   $
��Left=�6   $��35��6+   $��
13,135,0,0q�67   $	��Top=�6K   $��35��6c   $4��./LandConquest;component/Pictures/hourseman.png��6n   �� 5#   
   -
   5        $ sliderKnightsWas��5#      $
��Left=�6+   $��
48,152,0,0q�6F   $	��Top=�6Z   $	��114��6r   6�   �� 5$   
   -   5        $	 knightsCountWas��5$      $
��Left=�6w   $��
82,138,0,0q�6�   $	��Top=�6�   $��63��6�   ��6)   �� *Value+$
 sliderKnightsWas��$ {0:0}��6�   �� 5%   
   $
��Left=�6   $��35��6+   $��190,135,0,0q�67   $	��Top=�6L   $��35��6d   $4��./LandConquest;component/Pictures/hourseman.png��6o   �� 5&   
   -   5        $ sliderKnightsNow��5&      $
��Left=�6+   $��225,152,0,0q�6F   $	��Top=�6[   $	��114��6s   6�   �� 5'   
   -   5        $	 knightsCountNow��5'      $
��Left=�6w   $��259,138,0,0q�6�   $	��Top=�6�   $��63��6�   ��6)   �� *Value+$
 sliderKnightsNow��$ {0:0}��6�   �� 5(   
   $
��Left=�6   $��35��6+   $��
13,172,0,0q�67   $	��Top=�6K   $��35��6c   $3��-/LandConquest;component/Pictures/catapult.png��6n   �� 5)   
   -   5        $ sliderSiegeWas��5)      $
��Left=�6)   $��
48,189,0,0q�6D   $	��Top=�6X   $	��114��6p   6�   �� 5*   
   -   5        $	 siegeCountWas��5*      $
��Left=�6s   $��
82,175,0,0q�6�   $	��Top=�6�   $��63��6�   ��6'   �� *Value+$
 sliderSiegeWas��$ {0:0}��6�   �� 5+   
   $
��Left=�6   $��35��6+   $��190,172,0,0q�67   $	��Top=�6L   $��35��6d   $3��-/LandConquest;component/Pictures/catapult.png��6o   �� 5,   
   -   5        $ sliderSiegeNow��5,      $
��Left=�6)   $��225,189,0,0q�6D   $	��Top=�6Y   $	��114��6q   6�   �� 5-   
   -   5        $	 siegeCountNow��5-      $
��Left=�6s   $��259,175,0,0q�6�   $	��Top=�6�   $��63��6�   ��6'   �� *Value+$
 sliderSiegeNow��$ {0:0}��6�   �� 5.   
   $��Army Size: ��6   $
��Left=�6&   $��27��6A   $��	10,10,0,0q�6M   $	��Top=�6`   $��68��6x   �� 5/   
   -   5        $	 armySizeWas��5/      $��28(�6%   $��0��63   $
��Left=�6?   $��	13,23,0,0q�6Z   $	��Top=�6m   $��62��6�   $��44��6�   �� 50   
   $��Army Size: ��6   $
��Left=�6&   $��27��6A   $��
189,10,0,0q�6M   $	��Top=�6a   $��68��6y   �� 51   
   -   5        $	 armySizeNow��51      $��28(�6%   $��0��63   $
��Left=�6?   $��
192,23,0,0q�6Z   $	��Top=�6n   $��62��6�   $��44��6�   �� 52   
   -   5         ��Name$ armyTypeWasImg��52      $
��Left=�6(   $��50��6C   $��
106,10,0,0q�6O   $	��Top=�6c   $��50��6{   $��/Pictures/question.jpg��6�   �� 53   
   -   5        $ armyTypeNowImg��53      $
��Left=�6(   $��50��6C   $��
272,10,0,0q�6O   $	��Top=�6c   $��50��6{   $3��-/LandConquest;component/Pictures/question.jpg��6�   �� 54   
   -   5         ��Name$ btnSplitArmy��54      $��Detach��6'   
�������$
��Left=�6K   $��26��6f   $��242,212,0,0q�6r   $	��Top=�6�   $��80��6�   ��6�   Z� ��55      �� 56      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6   58      ��5:   
   �� 5;      $# /Pictures/background_pale.jpg��6   $ UniformToFill=�6E   5=      5>      5?      