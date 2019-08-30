using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid; 

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow _me;
        public Dictionary<string, GridControl> allGrid = new Dictionary<string, GridControl>();
        public MainWindow()
        {
            InitializeComponent();
            _me = this;
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var item in allGrid)
            {
                item.Value.SaveLayoutToXml($"{item.Key}.xml");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = uc.Template.FindName("txtBox1", uc) as TextBox;
            tb.Text = "TextBox1";
            lbt1.Content = new Car(_me) { Name = "124234", Year = "1928,10,10",ImagePath="afdasdf111\n" };
            var car = lbt1.Content as Car;
            
            TextBlock tbname= lbt1.FindName("name") as TextBlock;
            //tb.Text += tbname.Text;
        }
    }
}
