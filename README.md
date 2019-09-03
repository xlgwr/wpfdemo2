# wpfdemo2
dev grid 自定义 layout

# 隐藏表头右键菜单,其它显示
```     
gridControl.View.ShowGridMenu += View_ShowGridMenu;           
/// <summary>
/// 取消头右键功能
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
private void View_ShowGridMenu(object sender, GridMenuEventArgs e)
{
    switch (e.MenuType)
    {
        case GridMenuType.Column:
            Data_Grid.ContextMenu.Visibility = Visibility.Collapsed;
            //e.Customizations.Add(new RemoveBarItemAndLinkAction() { ItemName = DefaultColumnMenuItemNames.GroupBox });
            e.Handled = true; 
            break;
        default:
            Data_Grid.ContextMenu.Visibility = Visibility.Visible;
            break;
    }

}
```
