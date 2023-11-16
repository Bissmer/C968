using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Inventory.ExampleItems();
            //initialized datasource for parts and products
            var partTable = new BindingSource();
            partTable.DataSource = Inventory.getAllParts();
            partsGridView.DataSource = partTable;

            var productTable = new BindingSource();
            productTable.DataSource = Inventory.getProducts();
            productsGridView.DataSource = productTable;
        }

        private void addPartsMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int nextPartID = Inventory.GetNextPartId();
            var part = new addPart(nextPartID);
            part.ShowDialog();
            partsGridView.Refresh();
        }

        private void modifyPartsMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (partsGridView.CurrentRow.DataBoundItem.GetType() == typeof(InventoryManagementSystem.InHouse))
            {
                InHouse inhousePart = (InHouse)partsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)partsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }

        //enable modify and delete buttons when row is selected, if no rows are selected disable buttons
        private void partsTableGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0)
            {
                mainFormModifyPartsButton.Enabled = true;
                mainFormDeletePartsButton.Enabled = true;
            }
            else
            {
                mainFormModifyPartsButton.Enabled = false;
                mainFormDeletePartsButton.Enabled = false;
            }
        }

        private void mainFormDeletePartsButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (partsGridView.CurrentRow.DataBoundItem.GetType() == typeof(InHouse))
                {
                    InHouse inhousePart = (InHouse)partsGridView.CurrentRow.DataBoundItem;
                    Inventory.deletePart(inhousePart);
                }
                else
                {
                    Outsourced outsourcedPart = (Outsourced)partsGridView.CurrentRow.DataBoundItem;
                    Inventory.deletePart(outsourcedPart);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void mainFormAddProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int nextInventoryID = Inventory.GetNextProductId();
            var product = new AddProduct();
            product.ShowDialog();
            productsGridView.Refresh();
        }
    }
}

