using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfApp2NEW27062023
{
    /// <summary>
    /// Interaction logic for AssignmentWindow1.xaml
    /// </summary>
    public partial class AssignmentWindow1 : Window
    {
        public Product Products { get; set; }
        public ObservableCollection<Product> ObProducts { get; set; }
        public List<Product> ListProducts { get; set; }
        public AssignmentWindow1()
        {
            InitializeComponent();
            Products = new Product();
            ObProducts = new ObservableCollection<Product>();
            ListProducts = new List<Product>();
           // DataContext = this;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //ObProducts.Add(new Product()
            //{
            //    ProductName = Products.ProductName,
            //    ManDate = Products.ManDate,
            //    IsActive = Products.IsActive,
            //    CategoriesName = Products.CategoriesName
            //});
            ListProducts.Add(Products);
            
        }
    }
}
