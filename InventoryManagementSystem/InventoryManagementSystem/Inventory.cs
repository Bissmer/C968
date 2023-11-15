using System;
using System.ComponentModel;
using System.Windows.Forms;

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

        public static void addProduct(Product product)
        {
            products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            foreach (Product product in products)
            {
                if (product.ProductID == productID)
                {
                    products.Remove(product);
                    return true;
                }
            }

            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }

            return null;
        }

        public static void updateProduct(int productID, Product product)
        {
            foreach (Product prod in products)
            {
                if (prod.ProductID == productID)
                {
                    prod.Name = product.Name;
                    prod.InStock = product.InStock;
                    prod.Price = product.Price;
                    prod.Min = product.Min;
                    prod.Max = product.Max;
                }
            }
        }

        public static void addPart(Part part)
        {
            allParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            foreach (Part p in allParts)
            {
                if (p.PartId == part.PartId)
                {
                    allParts.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in allParts)
            {
                if (part.PartId == partID)
                {
                    return part;
                }
            }

            return null;
        }

        public static void updatePart(int partID, Part part)
        {
            foreach (Part p in allParts)
            {
                if (p.PartId == partID)
                {
                    p.Name = part.Name;
                    p.InStock = part.InStock;
                    p.Price = part.Price;
                    p.Min = part.Min;
                    p.Max = part.Max;
                }
            }
        }

        public static int generatePartID()
        {
            int initialID = 0;
            foreach (Part part in allParts)
            {
                if (part.PartId > initialID)
                {
                    initialID = part.PartId;
                }
            }

            return initialID + 1;
        }

        public static int generateProductID()
        {
            int initialProductID = 0;
            foreach (Product product in products)
            {
                if (product.ProductID > initialProductID)
                {
                    initialProductID = product.ProductID;
                }
            }

            return initialProductID + 1;
        }

        public static int GetNextPartId()
        {
            int maxId = 0;
            foreach (Part part in allParts)
            {
                if (part.PartId > maxId)
                {
                    maxId = part.PartId;
                }
            }
            return maxId + 1;
        }

        public static void ExampleItems()
        {
            Product exampleProd = new Product(1, "Example Product", 5, 5, 5, 10);
            products.Add(exampleProd);

            Part exampleInPart = new InHouse(1, "Example Inhouse Part", 11.5m, 5, 10, 20, 1001);
            Part exampleOutPart = new Outsourced(2, "Example Outsource Part", 22.7m, 1, 10, 45, "ACME Inc");
            allParts.Add(exampleInPart);
            allParts.Add(exampleOutPart);

        }
    }
}