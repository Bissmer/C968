using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Product
    {
        public BindingList<Part> associatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = Convert.ToInt32(productId);
            Name = name;
            Price = Convert.ToDecimal(price);
            InStock = Convert.ToInt32(inStock);
            Min = Convert.ToInt32(min);
            Max = Convert.ToInt32(max);
        }


        public void addAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partId)
        {
            bool removed = false;
            Part partToRemove = lookupAssociatedPart(partId);
            foreach (Part part in associatedParts)
            {
                if (partToRemove == null)
                {
                    removed = false;
                }
                else
                {
                    associatedParts.Remove(partToRemove);
                    removed = true;
                }
            }
            return removed;
        }

        public Part lookupAssociatedPart(int partId)
        {
            foreach (Part part in associatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
