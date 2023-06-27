using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace WpfApp2NEW27062023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowHelper Helper { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Helper = new MainWindowHelper();
            this.DataContext = Helper;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Helper.Save();
        }
    }

}
