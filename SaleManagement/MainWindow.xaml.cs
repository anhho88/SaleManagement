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

namespace SaleManagement {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        void _configStartUpLayout() {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.SystemParameters.WorkArea.Width * 0.85;
            this.Height = System.Windows.SystemParameters.WorkArea.Height * 0.85;
        }

        public MainWindow() {
            InitializeComponent();
            _configStartUpLayout();
        }

        private void closeApplication_MouseDown(object sender, MouseButtonEventArgs e) {
            Application.Current.Shutdown();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e) {
            try {
                this.DragMove();
            } catch { }
        }
    }
}
