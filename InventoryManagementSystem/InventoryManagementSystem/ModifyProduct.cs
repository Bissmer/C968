using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
    public partial class ModifyProduct : Form
    {
        private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        BindingList<Part> addedParts = new BindingList<Part>();
        public ModifyProduct(Product product)
        {
            InitializeComponent();

            modifyPrdProductIDTextBox.Text = product.ProductID.ToString();
            modifyPrdProductNameTextBox.Text = product.Name;
            modifyPrdProductInventoryTextBox.Text = product.InStock.ToString();
            modifyPrdProductPriceTextBox.Text = product.Price.ToString();
            modifyPrdProductMaxTextBox.Text = product.Max.ToString();
            modifyPrdProductMinTextBox.Text = product.Min.ToString();

            var modifyCandidParts = new BindingSource();
            modifyCandidParts.DataSource = Inventory.getAllParts();
            modifyPrdCandidatePartsGridView.DataSource = modifyCandidParts;

            foreach (Part part in product.associatedParts)
            {
                addedParts.Add(part);
            }

            var modifyAssociatedParts = new BindingSource();
            modifyAssociatedParts.DataSource = addedParts;
            modifyPrdAssociatedPartsGridView.DataSource = modifyAssociatedParts;


        }


        private void modifyPrdAddProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

    }
}
