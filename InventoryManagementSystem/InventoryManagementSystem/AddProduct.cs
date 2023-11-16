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
    public partial class AddProduct : Form
    {
        private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        BindingList<Part> associatedParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            var candidatePartsTable = new BindingSource();
            candidatePartsTable.DataSource = Inventory.getAllParts();
            candadatePartsGridView.DataSource = candidatePartsTable;

            var associatedPartsTable = new BindingSource();
            associatedPartsTable.DataSource = associatedParts;
            associatedPartsGridView.DataSource = associatedPartsTable;
        }
    }

}
