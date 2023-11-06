using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private static BindingList<Product> products = new BindingList<Product>();
        private static BindingList<Part> allParts = new BindingList<Part>();

        public static BindingList<Product> getProducts()
        {
            return products;
        }

        public static BindingList<Part> getAllParts()
        {
            return allParts;
        }

    }
}