   M S B A M L   `   `   `  ����G  CExemploFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ExemploFinalExemploFinal  5      $    ExemploFinal.TreinamentoEdicao   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ExemploFinal     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���	#FFDDDCDC � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��0��6   $��Imagens\Add_8x_16x.png��6$   $
��None=�6D   $��10q�6S   �� 5      $��1��6   $��Center=�6(   $��Edição de Treinamentos��6C   
�������$��Italic$�5      $
��Bold"�6+   $��20(�6=   $��Segoe WP)�5      �� 5      -   5        $��2��5      $��0q�6%   $��0,0,10,0q�69   $��Center=�5      $��Center=�62   $��15��5      .��5       �� $��Imagens\Close_16x.png��6   $��UniformToFill=�67   5!      5"      �� 5$   
   -   5         ��Name$ 	stkCampos��5$      $��1��6(   $��10q�65   .+�5%      �� $��Id��6   $
��Bold"�6"   �� 5&      $��50��6    �� 
IsReadOnly . $
��Left=�5'      ��5(      ��  �� Path$ twc_id��� 5*      $
��Nome��6   $
��Bold"�6$   $��0,10,0,0q�66   �� 5+      ��6   �� $ twc_nome� �� Mode$ TwoWay=��� 5-      $��Descrição��6   $
��Bold"�6)   $��0,10,0,0q�6;   �� 5.       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6+   $	��100��6?   ��5/      �� $ twc_descricao�$ TwoWay=��� 51      -   5         ��Name$ 	btnSalvar��51      $��0,10,0,0q�6(   $��80��6:   $��Right=�52      $��Salvar��61   53      54      55      56      