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
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public BindingList<Part> getAssociatedParts()
        {
            return associatedParts;
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
