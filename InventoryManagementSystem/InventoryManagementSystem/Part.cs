using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public abstract class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        //binding list is added for test purpose
        public static BindingList<Part> Parts = new BindingList<Part>();
        public Part(string partId, string name, string price, string inStock, string min, string max)
        {
            PartId = Convert.ToInt32(partId);
            Name = name;
            Price = Convert.ToDecimal(price);
            InStock = Convert.ToInt32(inStock);
            Min = Convert.ToInt32(min);
            Max = Convert.ToInt32(max);
        }

        public Part(string partId)
        {
            PartId = Convert.ToInt32(partId);
        }

        public Part()
        {

        }
    }
}
