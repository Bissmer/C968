using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
        public AddProduct(int productId)
        {
            InitializeComponent();
            SetupProductForm(productId);
        }

        private void SetupProductForm(int productId)
        {
            productIDTextBox.Text = productId.ToString();
            productIDTextBox.ReadOnly = true;
            BindGridView(candadatePartsGridView, Inventory.getAllParts());
            BindGridView(associatedPartsGridView, associatedParts);
        }

        private void BindGridView(DataGridView gridView, object dataSource)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            gridView.DataSource = bindingSource;
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void candidatePartsAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)candadatePartsGridView.CurrentRow.DataBoundItem;
            associatedParts.Add(part);
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int nextProductId = Inventory.GetNextProductId();
                int productId = nextProductId;
                string name = productNameTextBox.Text;
                int inStock = int.Parse(productInventoryTextBox.Text);
                decimal price = decimal.Parse(productPriceTextBox.Text);
                int max = int.Parse(productMaxTextBox.Text);
                int min = int.Parse(productMinTextBox.Text);

                if (max < min)
                {
                    MessageBox.Show("The Max value must be more than the Min value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory should be in range of min/max", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Product newProduct = new Product(productId, name, price, inStock, max, min);

                Inventory.getProducts().Add(newProduct);

                foreach (Part part in associatedParts)
                {
                    newProduct.addAssociatedPart(part);
                }
                this.Close();
                mainForm.Show();
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: A form can't be saved with empty fields.", "Empty Field Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void associatedPartsDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Part associatedPart = (Part)associatedPartsGridView.CurrentRow.DataBoundItem;
                associatedParts.Remove(associatedPart);
            }
            else return;
        }
    }

}
