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
            modifyPrdProductIDTextBox.ReadOnly = true;
            modifyPrdProductNameTextBox.Text = product.Name;
            modifyPrdProductInventoryTextBox.Text = product.InStock.ToString();
            modifyPrdProductPriceTextBox.Text = product.Price.ToString();
            modifyPrdProductMaxTextBox.Text = product.Max.ToString();
            modifyPrdProductMinTextBox.Text = product.Min.ToString();

            var modifyCandidParts = new BindingSource();
            modifyCandidParts.DataSource = Inventory.getAllParts();
            modifyPrdCandidatePartsGridView.DataSource = modifyCandidParts;

            foreach (Part part in product.AssociatedParts)
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

        private void modifyPrdAddProductSaveButton_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(modifyPrdProductIDTextBox.Text);
            string name = modifyPrdProductNameTextBox.Text;
            int inStock = int.Parse(modifyPrdProductInventoryTextBox.Text);
            decimal price = decimal.Parse(modifyPrdProductPriceTextBox.Text);
            int max = int.Parse(modifyPrdProductMaxTextBox.Text);
            int min = int.Parse(modifyPrdProductMinTextBox.Text);

            Product product = new Product(productID, name, price, inStock, max, min);

            foreach (Part part in addedParts)
            {
                product.addAssociatedPart(part);
            }
            Inventory.updateProduct(productID, product);

            this.Close();
            mainForm.Show();
            mainForm.partsGridView.Update();
            mainForm.partsGridView.Refresh();
        }

        private void modifyPrdCandidatePartsAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modifyPrdCandidatePartsGridView.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void modifyPrdAssociatedPartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (modifyPrdAssociatedPartsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("You need to press on a row first", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Part part = (Part)modifyPrdAssociatedPartsGridView.CurrentRow.DataBoundItem;
                    int id = int.Parse(modifyPrdProductIDTextBox.Text);

                    Product product = Inventory.lookupProduct(id);
                    product.removeAssociatedPart(part.PartId);

                    foreach (DataGridViewRow row in modifyPrdAssociatedPartsGridView.SelectedRows)
                    {
                        modifyPrdAssociatedPartsGridView.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
            
        }
        //perform a search by partId on parts all candidates gridview
        private void modifyPrdCandidatePartsSearchButton_Click(object sender, EventArgs e)
        {
            modifyPrdCandidatePartsGridView.ClearSelection();

            //validate input
            if (string.IsNullOrWhiteSpace(modifyPrdCandidatePartsSearchTextBox.Text) ||
                !int.TryParse(modifyPrdCandidatePartsSearchTextBox.Text, out int searchedPart) ||
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
            foreach (DataGridViewRow row in modifyPrdCandidatePartsGridView.Rows)
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
        private void modifyPrdAssociatedPartsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            modifyPrdAssociatedPartsDeleteButton.Enabled = modifyPrdAssociatedPartsGridView.Rows.Count > 0;
        }

        private void modifyPrdAssociatedPartsGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            modifyPrdAssociatedPartsDeleteButton.Enabled = modifyPrdAssociatedPartsGridView.Rows.Count > 0;
        }
    }
}
    

