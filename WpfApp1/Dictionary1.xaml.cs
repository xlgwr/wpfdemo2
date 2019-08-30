using DevExpress.Xpf.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class Dictionary1
    {
        private void Datagrid_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

            GridControl currGrid = (GridControl)sender;
            string keyName = "me";
            string keyNamePath = $"{keyName}.xml";
            if (File.Exists(keyNamePath))
            { 
                currGrid.RestoreLayoutFromXml(keyNamePath);
            }
            MainWindow._me.allGrid[keyName] = currGrid;

        }
    }
}
