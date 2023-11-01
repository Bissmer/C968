using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
     public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string partId, string name, string price, string inStock, string min, string max,
            string companyName)
        {
            PartId = Convert.ToInt32(partId);
            Name = name;
            Price = Convert.ToDecimal(price);
            InStock = Convert.ToInt32(inStock);
            Min = Convert.ToInt32(min);
            Max = Convert.ToInt32(max);
            CompanyName = companyName;
        }
    }
}
