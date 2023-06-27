using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2NEW27062023
{
    public class Product
    {
        public string ProductName { get; set; }
        public bool IsActive { get; set; }
        public string ActiveStatus { get {
                if (IsActive)
                { return "Active"; }
                else
                { return "Inactive"; }
            }  } 
        public string StatusColor { get {
                if (IsActive)
                { return "Green"; }
                else
                { return "Red"; }
            }  }
        public DateTime MfgDate { get; set; }
        public string MfgDateAsString    { get { return MfgDate.Date.ToString("dd/MM/yyyy"); } }
        public string ExpDate { get { return MfgDate.Date.AddMonths(6).ToString("dd/MM/yyyy"); } }
        
        public string CategoryName { get; set; }
      

    }
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }

}
