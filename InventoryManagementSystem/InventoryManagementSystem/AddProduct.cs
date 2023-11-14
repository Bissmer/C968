using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Add_Product : Form
    {
        private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        public Add_Product()
        {
            InitializeComponent();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            BindingList<Part> parts = Inventory.getAllParts();
            foreach (Part p in parts)
            {
                
            }
        }

    }
}
