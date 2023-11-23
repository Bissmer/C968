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
        BindingList<Part> addedParts = new BindingList<Part>();

        public AddProduct(int productId)
        {
            InitializeComponent();
            SetupProductForm(productId);
        }

        //form setup and gridview binding
        private void SetupProductForm(int productId)
        {
            productIDTextBox.Text = productId.ToString();
            productIDTextBox.ReadOnly = true;
            BindGridView(candidatePartsGridView, Inventory.getAllParts());
            BindGridView(associatedPartsGridView, addedParts);
        }

        private void BindGridView(DataGridView gridView, object dataSource)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataSource;
            gridView.DataSource = bindingSource;
        }

        //button event handlers
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
                    MessageBox.Show("The Max value must be more than the Min value.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory should be in range of min/max", "Invalid Input", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Product newProduct = new Product(productId, name, price, inStock, max, min);

                Inventory.getProducts().Add(newProduct);

                foreach (Part part in addedParts)
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

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void candidatePartsAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)candidatePartsGridView.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void associatedPartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (associatedPartsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You need to press on a row first", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Part associatedPart = (Part)associatedPartsGridView.CurrentRow.DataBoundItem;
                    addedParts.Remove(associatedPart);
                }
                else return;
            }
           
        }

        //perform a search by partId on parts all candidates gridview
        private void candidatePartsSearchButton_Click(object sender, EventArgs e)
        {
            candidatePartsGridView.ClearSelection();

            //validate input
            if (string.IsNullOrWhiteSpace(candidatePartsSearchTextBox.Text) ||
                !int.TryParse(candidatePartsSearchTextBox.Text, out int searchedPart) ||
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
            foreach (DataGridViewRow row in candidatePartsGridView.Rows)
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

        //enable delete button when row is added
        private void associatedPartsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            associatedPartsDeleteButton.Enabled = associatedPartsGridView.Rows.Count > 0;
        }

        private void associatedPartsGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            associatedPartsDeleteButton.Enabled = associatedPartsGridView.Rows.Count > 0;
        }

       
    }
    }

