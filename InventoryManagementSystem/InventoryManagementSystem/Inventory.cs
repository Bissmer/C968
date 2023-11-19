﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private static BindingList<Product> Products = new BindingList<Product>();
        private static BindingList<Part> AllParts = new BindingList<Part>();

        public static BindingList<Product> getProducts()
        {
            return Products;
        }

        public static BindingList<Part> getAllParts()
        {
            return AllParts;
        }

        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }

            return false;
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
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
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    prod.Name = product.Name;
                    prod.InStock = product.InStock;
                    prod.Price = product.Price;
                    prod.Min = product.Min;
                    prod.Max = product.Max;
                    prod.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
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
            DeletePart(partID);
            AddPart(part);
        }

        public static int generatePartID()
        {
            int initialID = 0;
            foreach (Part part in AllParts)
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
            foreach (Product product in Products)
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
            foreach (Part part in AllParts)
            {
                if (part.PartId > maxId)
                {
                    maxId = part.PartId;
                }
            }
            return maxId + 1;
        }

        public static int GetNextProductId()
        {
            int maxId = 0;
            foreach (Product product in Products)
            {
                if (product.ProductID > maxId)
                {
                    maxId = product.ProductID;
                }
            }
            return maxId + 1;
        }

        public static void ExampleItems()
        {
            Product exampleProd = new Product(1, "Example Product", 5, 6, 5, 10);
            Products.Add(exampleProd);

            Part exampleInPart = new InHouse(1, "Example Inhouse Part", 11.5m, 15, 20, 10, 1001);
            Part exampleOutPart = new Outsourced(2, "Example Outsource Part", 22.7m, 15, 45, 10, "ACME Inc");
            AllParts.Add(exampleInPart);
            AllParts.Add(exampleOutPart);

        }
    }
}