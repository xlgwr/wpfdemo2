using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class DemoDic
    {
    }
    /// <summary>  
    /// Car数据类型 -- 必须定义成属性{ get; set; }  
    /// </summary>  
    public class Car : NotificationObject
    {
        public MainWindow _currMain;
        public Car(MainWindow mainWindow)
        {
            _currMain = mainWindow;
        }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Automarker { get; set; }
        public string Year { get; set; }
    }
}
