   M S B A M L   `   `   `  ����F  BMasterFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterFloor.FramesMasterFloor.Frames  5      '    !MasterFloor.Frames.PartnerHistory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:MasterFloor.Frames     5        N� Title$  PartnerHistory��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      $��60 �6   6*   .+�5   
   �� -   5         ��Name$ 	EmptyText��5   D   $4��.История реализации пуста��5      $��Center=�63   $��Center=�6P   $��32(�5      $
��Bold"�6   $y�Hidden=�60   6Y   �� 5   
   -   5         ��Name$ HistoryListView��5      $	��800��6,   $��Center=�68   $y�Visible=�6U   $��Center=�5      $��0��67   ��5      �� 5      .R�5      �� 
���   �$��1q�61   $	��780��6E   $
��0 10q�6Q   ._�5      � $��10q�6   .+�5      ��  �� Orientation$ Vertical=�6)   .+�5   "   �� $
��Wrap=�6J   ��6,   �� *Product.Name+6`   �� 5   "   $
��Wrap=�6J   ��6,   �� *ProductCount+6`   �� 5   "   $
��Wrap=�6V   ��6,   �� *
SaleDate+ �� StringFormat$ d��6l   5      5      5      5      5!      �� 5"   
   -   5         ��Name$ 
BackButton��5"      $��
Назад��6%   $	��200��65   $��40��5#      $��Center=�5$      $
��Left=�6,   $��1��5%      $��10q�6   6E   5&      5'      