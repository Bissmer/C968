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
        private ErrorProvider _errorProvider;

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            modifyPrdIDTextBox.Text = product.ProductID.ToString();
            modifyPrdIDTextBox.ReadOnly = true;
            modifyPrdNameTextBox.Text = product.Name;
            modifyPrdInventoryTextBox.Text = product.InStock.ToString();
            modifyPrdPriceTextBox.Text = product.Price.ToString();
            modifyPrdMaxTextBox.Text = product.Max.ToString();
            modifyPrdMinTextBox.Text = product.Min.ToString();

            modifyPrdCandidatePartsGridView.DataSource = new BindingSource { DataSource = Inventory.getAllParts() };

            foreach (Part part in product.AssociatedParts)
            {
                addedParts.Add(part);
            }
            modifyPrdAssociatedPartsGridView.DataSource = addedParts;

            this.modifyPrdCancelButton.CausesValidation = false;
            this._errorProvider = new ErrorProvider();

        }

        private void modifyPrdAddProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void modifyPrdAddProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(modifyPrdIDTextBox.Text);
                string name = modifyPrdNameTextBox.Text;
                int inStock = int.Parse(modifyPrdInventoryTextBox.Text);
                decimal price = decimal.Parse(modifyPrdPriceTextBox.Text);
                int max = int.Parse(modifyPrdMaxTextBox.Text);
                int min = int.Parse(modifyPrdMinTextBox.Text);

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

                if (!ValidateNameField()) return;
                if (!ValidateMinMax(min, max)) return;
                if (!IsInStockWithinRange(inStock, min, max)) return;

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
            catch (FormatException ex)
            {
                MessageBox.Show("Input Error: A form can't be saved with invalid or empty fields.", "Empty Field Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

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
                    int id = int.Parse(modifyPrdIDTextBox.Text);

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
            if (!int.TryParse(modifyPrdCandidatePartsSearchTextBox.Text, out int searchedPart) || searchedPart < 1)
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
            UpdateDeleteButtonState();
        }

        private void modifyPrdAssociatedPartsGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateDeleteButtonState();
        }

        private void UpdateDeleteButtonState()
        {
            modifyPrdAssociatedPartsDeleteButton.Enabled = modifyPrdAssociatedPartsGridView.Rows.Count > 0;
        }


        //Modify product form fields validation
        private bool ValidateNameField()
        {
            if (string.IsNullOrWhiteSpace(modifyPrdNameTextBox.Text))
            {
                SetTextBoxErrorState(modifyPrdNameTextBox, "The Name field cannot be empty.");
                return false;
            }
            else
            {
                ResetTextBoxState(modifyPrdNameTextBox);
                return true;
            }
        }

        private void modifyPrdProductNameTextBox_Validated(object sender, EventArgs e)
        {
            ValidateNameField();
        }

        private void modifyPrdProductInventoryTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Inventory field must have a numeric value.");

        }
        private void modifyPrdProductPriceTextBox_Validating(object sender, EventArgs e)
        {
            decimal value;
            if (!Decimal.TryParse(modifyPrdPriceTextBox.Text, out value))
            {
                SetTextBoxErrorState(modifyPrdPriceTextBox, "The Price field must have a numeric value.");
            }
            else
            {
                ResetTextBoxState(modifyPrdPriceTextBox);
            }
        }
        private void modifyPrdProductMaxTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Max field must have a numeric value.");
        }

        private void modifyPrdProductMinTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Min field must have a numeric value.");
        }

        //validation for the name mix/max and inventory fields
        private bool ValidateMinMax(int min, int max)
        {
            if (max < min)
            {
                MessageBox.Show("The Max value must be higher than the Min value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsInStockWithinRange(int inStock, int min, int max)
        {
            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory should be in range of min/max", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //functions for setting/resetting the error state of the text box
        private void SetTextBoxErrorState(TextBox textBox, string errorMessage)
        {
            textBox.BackColor = Color.LightCoral;
            _errorProvider.SetError(textBox, errorMessage);
        }

        private void ResetTextBoxState(TextBox textBox)
        {
            _errorProvider.SetError(textBox, "");
            textBox.BackColor = Color.White;
        }

        //functions for validating input for numeric val
        private void ValidateNumericInput(object sender, string errorMessage)
        {
            TextBox textBox = (TextBox)sender;
            if (!IsNumeric(textBox.Text))
            {
                SetTextBoxErrorState(textBox, errorMessage);
            }
            else
            {
                ResetTextBoxState(textBox);
            }
        }
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}

    

