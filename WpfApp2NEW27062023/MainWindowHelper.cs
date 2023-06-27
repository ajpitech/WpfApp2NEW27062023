using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2NEW27062023
{
    public class MainWindowHelper : INotifyPropertyChanged
    {
        public Product Products { get; set; }

        public List<Category> Categories { get; set; }
        public Category SelectedCategory { get; set; }
        public List<Brand> Brands { get; set; }
        public Brand SelectedBrand { get; set; }
        public ObservableCollection<Product> ObProducts { get; set; }
        public MainWindowHelper()
        {
            Products = new Product();
            Categories = new List<Category>() {
                new Category() { CategoryName = "Mobile", Id = 1 },
                new Category() { CategoryName = "Tv", Id = 2 },
                new Category() { CategoryName = "Laptop", Id = 3 }
            }; 
            Brands = new List<Brand>() {
                new Brand() { BrandName = "Dell", Id = 2 },
                new Brand() { BrandName = "Hp", Id = 3 },
                new Brand() { BrandName = "Circle", Id = 1 },
            };

            ObProducts = new ObservableCollection<Product>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public void Save()
        {
            ObProducts.Add(new Product()
            {
                ProductName = Products.ProductName,
                MfgDate = Products.MfgDate,
                IsActive = Products.IsActive,
                CategoryName = SelectedCategory.CategoryName
            });


            var obj = new ObservableCollection<Product>(ObProducts.OrderBy(x => x.CategoryName));

            ObProducts = obj;

            OnPropertyChange("ObProducts");
        }
    }
}
