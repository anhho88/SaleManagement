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

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private void windowStartup() {
            double wScale = 1;
            double hScale = 1;
            this.Width = SystemParameters.WorkArea.Width * wScale;
            this.Height = SystemParameters.WorkArea.Height * hScale;
        }

        private void bringUCtoFront(int index) {
            List<Control> list = new List<Control>() { ucProduct, ucBrand, ucSupplier, ucStock };
            for(int i = 0; i < list.Count; i++) {
                if(i==index) Canvas.SetZIndex(list[i], 1);
                else Canvas.SetZIndex(list[i], 0);
            }
        }

        public MainWindow() {
            InitializeComponent();
            this.windowStartup();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            this.DragMove();
        }

        private void btnClose_MouseDown(object sender, MouseButtonEventArgs e) {
            this.Close();
        }

        private void SignControl (object sender, MouseButtonEventArgs e) {
            Label s = sender as Label;
            Dictionary<string, int> dictionary = new Dictionary<string, int>() { { "All Products", 0 }, { "Brands", 1 }, { "Suppliers", 2 }, { "Stock", 3 } };
            int t;
            bool ret = dictionary.TryGetValue(s.Content.ToString(), out t);
            this.lblSign.Margin = new Thickness(t * 100, 0, 0, 0);
            bringUCtoFront(t);
        }

    }
}
