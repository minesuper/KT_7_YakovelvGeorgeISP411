   M S B A M L   `   `   `  ���� F  BMasterFloor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:MasterFloor.FramesMasterFloor.Frames  '    !MasterFloor.Frames.AddEditPartner   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:MasterFloor.Frames       N� Title$  AddEditPartner��.��� 
������� � RowDefinitions �� �� $��60 �.+�� $��0��$��Center=�$��Center=� � ColumnDefinitions �� �� �� ��  �� �� �� �� .+��� $��Наименование:��$��0��$��0��$��Right=�$��Center=��� $��Тип партнера:��$��1��$��0��$��Right=�$��Center=��� $��Рейтинг:��$��2��$��0��$��Right=�$��Center=��� $��Адрес:��$��3��$��0��$��Right=�$��Center=��� $ ��ФИО Директора:��$��0��$��2��$��Right=�$��Center=��� $��Телефон:��$��1��$��2��$��Right=�$��Center=��� $��Email:��$��2��$��2��$��Right=�$��Center=��� -    ��Name$ NameTextBox��$��0�� �� 	MaxLength$ 50��$��1��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -    ��Name$ TypeComboBox��$��1��$��10q�$��1��$	��190��$��40�� �� DisplayMemberPath$
 Name��$
��Left=�$��Center=��� -   $ RatingTextBox��$��2��$ 10��$��1��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -   $ AdressTextBox��$��3��$	 250��$��1��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -   $ 
FIOTextBox��$��0��$	 150��$��3��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -   $ PhoneTextBox��$��1��$ 50��$��3��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -   $ EmailTextBox��$��2��$ 50��$��3��$	��190��$��40��$��10q�$
��Left=�$��Center=��� -    ��Name$ 
BackButton��$��
Назад��$	��200��$��40��$��Center=�$
��Left=�$��1��$��10q��� -	   $ 
SaveButton��$��Сохранить��$	��200��$��40��$��Center=�$��Right=�$��1��$��10q�