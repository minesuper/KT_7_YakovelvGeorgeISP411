   M S B A M L   `   `   `  ���� F  BMasterFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterFloor.FramesMasterFloor.Frames  '    !MasterFloor.Frames.PartnerHistory   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:MasterFloor.Frames       N� Title$  PartnerHistory��.��� 
������� � RowDefinitions �� �� $��60 �.+��� -    ��Name$ 	EmptyText��$4��.История реализации пуста��$��Center=�$��Center=�$��32(�$
��Bold"�$y�Hidden=��� -    ��Name$ HistoryListView��$	��800��$��Center=�$y�Visible=�$��Center=�$��0������ .R��� 
���   �$��1q�$	��780��$
��0 10q�._�� $��10q�.+���  �� Orientation$ Vertical=�.+��� $
��Wrap=����� *Product.Name+�� $
��Wrap=����� *ProductCount+�� $
��Wrap=����� *
SaleDate+ �� StringFormat$ d���� -    ��Name$ 
BackButton��$��
Назад��$	��200��$��40��$��Center=�$
��Left=�$��1��$��10q�