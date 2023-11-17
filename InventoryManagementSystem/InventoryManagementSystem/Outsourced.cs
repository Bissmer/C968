using System;

namespace InventoryManagementSystem
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, decimal price, int inStock, int max, int min,
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
