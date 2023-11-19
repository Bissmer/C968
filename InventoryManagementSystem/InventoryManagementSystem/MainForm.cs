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

        private void productsTableGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count > 0)
            {
                mainFormModifyProductsButton.Enabled = true;
                mainFormDeleteProductsButton.Enabled = true;
            }
            else
            {
                mainFormModifyProductsButton.Enabled = false;
                mainFormDeleteProductsButton.Enabled = false;
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
                    Inventory.DeletePart(inhousePart.PartId);
                }
                else
                {
                    Outsourced outsourcedPart = (Outsourced)partsGridView.CurrentRow.DataBoundItem;
                    Inventory.DeletePart(outsourcedPart.PartId);
                }
            }
        }

        private void mainFormAddProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int nextProductID = Inventory.GetNextProductId();
            var product = new AddProduct(nextProductID);
            product.ShowDialog();
            productsGridView.Refresh();
        }

        private void mainFormModifyProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = (Product)productsGridView.CurrentRow.DataBoundItem;
            new ModifyProduct(product).ShowDialog();
            
        }

        //perform a search by partId on Parts gridview
        private void mainFormPartsSearchButton_Click(object sender, EventArgs e)
        {

            partsGridView.ClearSelection();

            //validate input
            if (string.IsNullOrWhiteSpace(mainFormPartsSearchTextBox.Text) ||
                !int.TryParse(mainFormPartsSearchTextBox.Text, out int searchedPart) ||
                searchedPart < 1)
            {
                MessageBox.Show("Please enter a valid Part ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Part matchPart = Inventory.LookupPart(searchedPart);

            if (matchPart == null)
            {
                MessageBox.Show("Part ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //select row with matching partId or throw "Part not found" error
            bool isPartFound = false;
            foreach (DataGridViewRow row in partsGridView.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartId == matchPart.PartId)
                {
                    row.Selected = true;
                    isPartFound = true;
                    break;
                }
                
            }
            if (!isPartFound)
            {
                MessageBox.Show("Part not found.", "Part not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainFormProductsSearchButton_Click(object sender, EventArgs e)
        {
            productsGridView.ClearSelection();

            //validate input
            if (string.IsNullOrWhiteSpace(mainFormProductsSearchTextBox.Text) ||
                !int.TryParse(mainFormProductsSearchTextBox.Text, out int searchedProduct) ||
                searchedProduct < 1)
            {
                MessageBox.Show("Please enter a valid Product ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Part matchProduct = Inventory.LookupPart(searchedProduct);

            if (matchProduct == null)
            {
                MessageBox.Show("Product ID not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //select row with matching partId or throw "Part not found" error
            bool isProductFound = false;
            foreach (DataGridViewRow row in productsGridView.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == matchProduct.PartId)
                {
                    row.Selected = true;
                    isProductFound = true;
                    break;
                }

            }
            if (!isProductFound)
            {
                MessageBox.Show("Product not found.", "Part not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainFormDeleteProductsButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsGridView.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Product has associated parts. Please remove all associated parts before deleting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in productsGridView.SelectedRows)
                    {
                        productsGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

