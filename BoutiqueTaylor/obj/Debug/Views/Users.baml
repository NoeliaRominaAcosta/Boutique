   M S B A M L   `   `   `  ????I  EBoutiqueTaylor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BoutiqueTaylor.ViewsBoutiqueTaylor.Views  5           BoutiqueTaylor.Views.Users   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:BoutiqueTaylor.Views     5      
??????   ? 	Resources  5         TextBox.Static.Border ?? Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle ?? 
TargetType ?? Property ?? Value-  'System.Windows.Input.KeyboardNavigation ?? 
TargetType ??Name ?? CornerRadius J? SnapsToDevicePixels	 ??Name
 ?? Triggers P? Property P? Value ?? 
TargetName ?? Triggers ]? 
Conditions ?? Property ?? Value  FocusVisual ?? StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border 	 Button.Pressed.Background 
 Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonSearch ??Name  DataGridStyle&   System.Windows.Controls.DataGrid ?? Padding ? ColumnDefinitions ? RowDefinitions   SelectAllCommand ?? 
ResourceId ?? TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All ?? ConverterParameter!   HeadersVisibilityConverter ?? 	Converter ?? RelativeSource ?? AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter   Name!   Column" ??Name# ?? CanContentScroll$ ??Name% ?? ScrollableHeight& ? Maximum' ?? Orientation*( ?? #ComputedVerticalScrollBarVisibility) ?? ViewportHeight* ?? ViewportSize+ ? Value, ?? Mode- ?? ScrollableWidth,. ?? %ComputedHorizontalScrollBarVisibility/ ?? ViewportWidth=  7System.Windows.Controls.Primitives.DataGridColumnHeader??%s  &	        &	 #     &	 F     &	 i     7   7  7  &	 o    &	     &	 <    &	 _    &	 ?    &		 ?    &	
 ?    &	 ?    &	     &	 1    &	 T    7  7  7  7  7  7  &	 K    '  ?    ?? 5   
   $ 	#FFABAdB3??68   ?? 5   
   $ 	#FF7EB4EA??6;   ?? 5   
   $ 	#FF569DE5??67   ?? 5   
   " ??6%   .?5      ??  ? ??# ? ??6+   ?? 5       ? ??8   6,   ?? 5       ? ??# ? ??6+   ?? 5       ? ??$ 1q?60   ?? 5       ?@ TabNavigation$
 None=?6A   ?? 5       ? ??$
 Left=?6;   ?? 5       ?@?FocusVisualStyle 61   Z? ?? 5       ?@J?	AllowDrop . 6*   ?? 5       ?@??PanningMode$ VerticalFirst=?69   ?? 5       ?@??IsFlicksEnabled .  67   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ?? $ border??63   $ 10??6!   #??z??6C   #??z??6o   #??z??6?    . ._?5      ?? $	 PART_ContentHost??6+   |?.  $??Hidden=?6W   $??Hidden=?6~   5      
 5       P? 5!       ? {? .  . ?5"   "   ?? $ border??6<    ?@J?Opacity$
 0.56Q?6P   5#      P? 5$       ?@J?IsMouseOver . . ?5%   "   ?? $ border??6@   8   ? ??6T   5&      P? 5'       ?@J?IsKeyboardFocused . . ?5(   "   ?? $ border??6@   8   ? ??6T   5)      5+      5-       5.      ]? 5/       50      ?? 51      + ?@??#IsInactiveSelectionHighlightEnabled . 6S   ?? 52       ?@??IsSelectionActive .  6A   ./?54      ??  ?@??SelectionBrush# ? /?67   55      57      ?? 58   
   .?59      ??  ? ?? 5:      ?? 5;      .R?5<      ?? $??2q?6$    . #??? ??6J   $??1??6?   $	 1 2R?6?   5=      5?      5@      ?? 5A   
   $ 	#FFDDDDDD??6;   ?? 5B   
   $ 	#FF707070??67   ?? 5C   
   $ 	#FFBEE6FD??6>   ?? 5D   
   $ 	#FF3C7FB1??6:   ?? 5E   
   $ 	#FFC4E5F6??6<   ?? 5F   
   $ 	#FF2C628B??68   ?? 5G   
   $ 	#FFF4F4F4??6=   ?? 5H   
   $ 	#FFADB2B5??69   ?? 5I   
   $ 	#FF838383??6=   ?? 5J   
   " ??6%   .?5K      ??  ?@?FocusVisualStyle8   61   ?? 5L       ? ??8  6+   ?? 5M       ? ??8  6,   ?? 5N       ? ??# ? ??6+   ?? 5O       ? ??$ 1q?60   ?? 5P       ? ??$ Center=?6;   ?? 5Q       ? ??$ Center=?69   ?? 5R       ? ??$ 1q?6(   ?? 5S       ? ?? 5T      ?? 5U      " ??6&   .R?5V      ?? $ border??63   $ 10??6!   #??z??6C   #??z??6o   #??z??6?    . ._?5W      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. # z 6?   #??z??6  5X      
 5Y      P? 5Z       ?@??IsDefaulted . . ?5[   "   ?? $ border??6@   # ? ??6T    ? ??5\      P? 5]       ?@J?IsMouseOver . . ?5^   "   ?? $ border??6?    ? ?? ?#8D80AD6S   ?? 5_   "   $ border??6@    ? ?? ?#8D80AD6T   5`      P? 5a       ? ?? . . ?5b   "   ?? $ border??6?    ? ?? ?#CAAFB16S   ?? 5c   "   $ border??6@    ? ?? ?#CAAFB16T   5d      P? 5e       ? {? .  . ?5f   "   ?? $ border??6?   8   ? ??6S   ?? 5g   "   $ border??6@   8   ? ??6T   ?? 5h   "   $ contentPresenter??6K   8   ? ??6i   5i      5k      5m      5n      ?? 5o   
   "  6&   .?5p      ??  ? ??# ? ??6+   ?? 5q       ? ??# ? ??6+   ?? 5r       ? ?? ?	#FF688CAF6,   ?? 5s       ? ??$ 1q?60   ?? 5t        ?@ RowDetailsVisibilityMode$ VisibleWhenSelected=?69   ?? 5u       ? ?? . 6>   ?? 5v       ?@??PanningMode$
 Both=?69   ?? 5w       ?@??IsFlicksEnabled .  67   ?? 5x       ? ?? 5y      ?? 5z      "  6&   .R?5{      ?? $ 	0,0,10,10??6!   #??z??6:   #??z??6f   #??z??6?   # z??6?    . ._?5|      ?? $	 DG_ScrollViewer??6+   |?.  ??5}   "   ?? 5~   &   " ??66   .R?5   *   ?  5?   .   ?? 5?   2   $
??Auto ?6C   ?? 5?   2   $??* ?6C   ?? 5?   2   $
??Auto ?6C    5?   .   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $??* ?6@   ?? 5?   2   $
??Auto ?6@   .+?5?   .   ?? #??Z 65   |?.  ??6v   C? *?? $" DataGridSelectAllButtonStyle??"  +y?6?   ?? *HeadersVisibility+# Z # Z  ?? "  ??6?  ?? *CellsPanelHorizontalOffset+ ?? "    5?   .   $!  PART_ColumnHeadersPresenter??6M   $??1??6r   y?6?   ?? *HeadersVisibility+# Z! # Z  ?? "  ?? 5?   .   $!" PART_ScrollContentPresenter??6E   ## z??6j   $??2??6?   $??1??6?   ?? 5?   .   $$ PART_VerticalScrollBar??68   $??2??6X   #& z% 6h   $' Vertical=?6?   $??1??6?   #y?z( 6?   #* z) 6[  + 6?   ?? *VerticalOffset+$, OneWay=? ?? *TemplatedParent+6[  ? 5?   .   $??1??63   $??2??6C    5?   2   ?? 5?   6   ??6G   ?? **(NonFrozenColumnsViewportHorizontalOffset+ ?? "  ?? 5?   6   $??* ?6G   .+?5?   2   ?? $$ PART_HorizontalScrollBar??6<   $??1??6^   #& z- 6n   $' 
Horizontal=?6?   #y?z. 6?   #* z/ 6Y  + 6?   ?? *HorizontalOffset+$, OneWay=? ?? *TemplatedParent+6Y  5?   /   5?   +   5?   '   .??5?   "   ?? # z 61   5?      5?      5?      5?       5?      ]? 5?       5?      ?? 5?       ?@??
IsGrouping . 6:   ?? 5?      " ?@%?IsVirtualizingWhenGrouping .  6\   ./?5?      ??  ? ?? .  6F   5?      5?      ?? 5?   
   "  6   .?5?      ??  ? ?? ?#8D80AD6+   ?? 5?       ? ??$ SemiBold"?6+   ?? 5?       ? ??$ 20??6'   ?? 5?       ? ??
 ?????6+   ?? 5?       ? ??$ Center=?6;   5?      5?      .??5?      ?? $ 10??6   
?????? ._?5?   
   ? -   5        $??	GridUsers??5?      .+?5?      ? -   5        $??content??5?      $??0??5?      $??0??5?      $??6??5?      $??8??5?       5?      ?? 5?      $??20 ?6'   ?? 5?      ?? 5?      ?? 5?      ?? 5?      ?? 5?      $??20 ?6'    5?      ?? 5?      $??50 ?6$   ?? 5?      $??20 ?6$   ?? 5?      $??30 ?6$   ?? 5?      $??20 ?6$   ?? 5?      ?? 5?      ?? 5?      ?? 5?      $??20 ?6$   .+?5?      ?? $??0??6   $??6??5?      $??Mantenimiento usuarios??5?      
???   ?$??30(?5?      $??Center=?5?      $??Center=?5?      ?? 5?      $??Buscar usuario??6   $??Right=?5?      $??Center=?5?      $??1??5?      $??2??5?      $??15(?5?      $??0,0,10,0q?5?      ?? 5?      0 ?? TextAlignment$0 Center=?6   
?????? ???#CAAFB1$??2??5?      $??2??5?      #???  6#   ?? 5?      -   5        $??	BtnSearch??5?      $??3??5?      $??2??5?      ???#CAAFB1???#CAAFB1$??10,0,0,0q?5?      1 ? Cursor$
1 Hand??5?      $	??100??5?      $
??Left=?5?      #???  60   .??5?      ?? $??Buscar??6    
???????$??15(?5?      5?      5?      ?? 5?      -   5        $??BtnCreateUser??5?      ???#8D80AD???#8D80AD$??4??5?      $??2??5?      $
1 Hand??5?      $	??150??5?      #???  5?      .??5?      ?? $??Crear nuevo??6    
???????$??15(?5      5       5     -   5        $??GridData??5	     $??4??5     $??1??5     $??2??5     $??4??5     2   AutoGenerateColumns2 .  
???????
???OO/?3   CanUserAddRows3 .  4   CanUserResizeColumns4 .  5   CanUserResizeRows5 .  6   RowBackground
6 ???? 7   HeadersVisibility$7 Column=?5     8   GridLinesVisibility$8 
Horizontal=?5     9   HorizontalGridLinesBrush9 ?#8D80AD#???  5  :   :   Columns: 5     4  .System.Windows.Controls.DataGridTemplateColumn  5     ,  &System.Windows.Controls.DataGridColumn;   Header$; Admin??61   <   Width5  /System.Windows.Controls.DataGridLengthConverter$	< 245 5  -   =   CellTemplate= 5     ?? 5  "   .R?5  &   ]? .+?5  *   ?? $??	btnSearch??61   -   5        $??	Consultar??5  -   ???#8D80AD$??80??5  -   
?????? 
???????$
1 Hand??5   -   #???  5!  -   ??5#  -   ?? *	id_user+?? 5$  *   $??	btnUpdate??61   -   5        $??	Modificar??5%  -   ???#8D80AD
???????$??80??5(  -   $
1 Hand??5)  -   
?????? #???  5+  -   ??5,  -   ?? *	id_user+6R   ?? 5-  *   $??	btnDelete??61   -   5        $??Borrar??5.  -   
??????????#8D80AD$
1 Hand??51  -   $??80??52  -   
?????? #???  54  -   ??55  .   ?? *	id_user+6S   56  '   57  #   59     0	  *System.Windows.Controls.DataGridTextColumn	  5:     $; ID??6-   $< 50 5;  )   1
  +System.Windows.Controls.DataGridBoundColumn> 
  Binding> 5<  )   ?? *	id_user+	  5=     $; Nombre??6-   $	< 100 5>  )   > 5?  *   ?? *name+	  5@     $; Apellido??6-   $	< 100 5A  )   > 5B  *   ?? *
lastname+	  5C     $; Email??6-   $< * 5D  )   > 5E  *   ?? *email+	  5F     $; 
Privilegio??6-   $< * 5G  )   > 5H  )   ?? *	userRol+5J     5L      ? 5O     -	   5        $??
FrameUsers??5O     $??0??5P     $??0??5Q     $??8??5R     $??6??5S     5U     5V     5W     