   M S B A M L   `   `   `  ����   audioeditor    Audioeditor.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  AudioEditor��$	��850��$
��1320�� � AllowsTransparency$
 True�� � WindowStyle$
 None=� � 
ResizeMode$ CanResizeWithGrip=�$��1q����#3B3C46 J� 	AllowDrop$
 True�����#ffffff���#000000 �� 	IsEnabled$
 True�� 	  Inter#��[  .���  � RowDefinitions �� $��57 �$��57��$��57���� $��57 �$��57��$��57���� $��* ��� $
��Auto �$	��300�� � ColumnDefinitions �� $	��270 �$��40���� .+��� -   $��0��$��0��$��2�����#b816cc�� $��0��$��0��$��2�� �� Orientation$ 
Horizontal=�$��0q�.+�o� $
��15px(����#b816cc���#ffffff$��8,0,8,0q�$��57��$
��Left=�#��[  .@�m� $
��File��$��10,18,10,18q�$��57��.@�m� -   $	��New��m� -   $
��Open��m� -   $
��Save��m� -   $��Save as��m� -   $��Export��m� $
��Edit��$��10,18,10,18q�$��57��.@�m� -   $��Deselect��m� -	   $	��Cut��m� -
   $��Double��m� -   $��Delete��m� $��Effects��$��10,18,10,18q�$��57��.@�m� -   $��Compress��m� -   $��Reverb��m� -   $��Fade in��m� -   $��Fade out��	 � 	Resources	 
 �� 
TargetType �� Property �� Value��%H   'm�       �� "
 m�.���  � ��$ 0q���  � �� �#b816cc�� -    ��Name$ ConsoleTextBlock���� $��0��$��0��$��2��$��Right=�$ 
Horizontal=�$��0q�.+��� -   $��57��$��57��$	��─��$
��20px(�$��Light"����#ffffff���#b816cc$��0q�$��0,0,0,3q��� -   $��57��$��57��$	��◻��$
��20px(�$��Light"����#ffffff���#b816cc$��0q�$��0,0,0,2q��� -   $��57��$��57��$	��✕��$
��17px(�$
��Bold"����#ffffff���#b816cc$��0q�$��0,0,0,2q��� $��0��$��0��$��2��$��1��$��Stretch=����#000000$��Bottom=�${�False�� �� ShowsPreview$ False���� $��1��$��0��$��2��$��Center=�$��Center=�$ 
Horizontal=�$��0q�.+��� -   $ TimeRunnerPosition��$��18(�$��21,0,0,0q����#000000�� -    ��Name$ pauseButton��$y�	Collapsed=�$��15�� � Cursor$
 Hand��$��/Icons/pause_b.png��$��30,0,0,0q� �� BitmapScalingMode$
 Fant=��� -   $ 
playButton��$��15��$
 Hand��$��/Icons/play_b.png��$��30,0,0,0q�$
 Fant=��� -   $ beginButton��$��12��$
 Hand��$��/Icons/begin_b.png��$��30,0,0,0q�$
 Fant=��� $��1��$��0��$��2��$��1��$��Stretch=����#000000$��Bottom=�${�False��$ False���� -    ��Name$ 	ListView3��$��3��$��0��$��2��$��0q����#ffffff$��Hidden=�$��False��  СhannelCard#��[ ���� *
Channels+���� .R��� $ 
Horizontal=��� -    ��Name$ CanvasScrollViewer��$��2��$��2��.���� -    ��Name$ WorkFieldCanvas��$	��Top=�$��Stretch=����#ffffff$
��Auto�� K� ZIndex$ 0��$
|�True���� $��2��$��0��$��6��$��Right=�
������ $��Stretch=�$ False���� $��3��$��0��$��2��$��6��$��Stretch=�
������ $	��Top=�$ False���� $��3��$��0��$��2��$��1��$��Stretch=����#000000$	��Top=�$ False��${�False��