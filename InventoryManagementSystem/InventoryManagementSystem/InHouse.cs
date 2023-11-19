using System;

namespace InventoryManagementSystem
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse() {}
        public InHouse(int partId, string name, decimal price, int inStock, int max, int min, int machineId)
        {
            PartId = Convert.ToInt32(partId);
            Name = name;
            Price = Convert.ToDecimal(price);
            InStock = Convert.ToInt32(inStock);
            Min = Convert.ToInt32(min);
            Max = Convert.ToInt32(max);
            MachineID = Convert.ToInt32(machineId);
        }
    }
}