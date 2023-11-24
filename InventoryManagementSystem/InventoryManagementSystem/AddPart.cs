using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ToolTip = System.Windows.Forms.ToolTip;

namespace InventoryManagementSystem
{
    public partial class addPart : Form
    {
        public MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        private ErrorProvider _errorProvider;

        public addPart(int partID)
        {
            InitializeComponent();
            addPartIdtTextBox.Text = partID.ToString();
            addPartIdtTextBox.ReadOnly = true;
            this.cancelAddPartBtn.CausesValidation = false;
            this._errorProvider = new ErrorProvider();
        }

        //saving information on Save button click in Add part form
        private void saveAddPartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int nextPartId = Inventory.GetNextPartId();
                int partId = nextPartId;
                string name = addPartNameTextBox.Text;
                string companyName = addPartOutsourcedRadio.Checked ? addPartMachineCompanyTextBox.Text : String.Empty;
                int machineID = int.Parse(addPartOutsourcedRadio.Checked ? "0" : addPartMachineCompanyTextBox.Text);
                int inStock = int.Parse(addPartInventoryTextBox.Text);
                decimal price = decimal.Parse(addPartPriceTextBox.Text);
                int max = int.Parse(addPartMaxTextBox.Text);
                int min = int.Parse(addPartMinTextBox.Text);

                if (!ValidateNameField()) return;
                if(!ValidateCompanyNameField()) return;
                if (!ValidateMinMax(min, max)) return;
                if (!IsInStockWithinRange(inStock, min, max)) return;

                Part newPart = addPartOutsourcedRadio.Checked
                    ? (Part)new Outsourced(partId, name, price, inStock, max, min, companyName)
                    : new InHouse(partId, name, price, inStock, max, min, machineID);

                Inventory.getAllParts().Add(newPart);
                this.Close();
                mainForm.Show();
            }
            catch (FormatException ex)
            {
                string errorMessage = "Input Error: A form can't be saved with invalid or empty fields.";
                MessageBox.Show(errorMessage, "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelAddPartBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        //common function for numeric input validation
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

        //validation of fields on the add part form

        private bool ValidateNameField()
        {
            if (string.IsNullOrWhiteSpace(addPartNameTextBox.Text))
            {
                SetTextBoxErrorState(addPartNameTextBox, "The Name field cannot be empty.");
                return false;
            }
            else
            {
                ResetTextBoxState(addPartNameTextBox);
                return true;
            }
        }

        private bool ValidateCompanyNameField()
        {
            if (addPartOutsourcedRadio.Checked)
            {
                if (string.IsNullOrWhiteSpace(addPartMachineCompanyTextBox.Text))
                {
                    SetTextBoxErrorState(addPartMachineCompanyTextBox, "The Company Name field cannot be empty.");
                    return false;
                }
                else
                {
                    ResetTextBoxState(addPartMachineCompanyTextBox);
                    return true;
                }
            }
            return true;
        }

        private void addPartNameTextBox_Validated(object sender, EventArgs e)
        {
            ValidateNameField();
        }

        private void addPartInventoryTextBox_Validated(object sender, EventArgs e)
        {
           ValidateNumericInput(sender, "The Inventory field must have a numeric value.");

        }

        private void addPartPriceTextBox_Validated(object sender, EventArgs e)
        {
            decimal value;
            if (!Decimal.TryParse(addPartPriceTextBox.Text, out value))
            {
                SetTextBoxErrorState(addPartPriceTextBox, "The Price field must have a numeric value.");
            }
            else
            {
                ResetTextBoxState(addPartPriceTextBox);
            }
        }
        private void addPartMaxTextBox_Validated(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Max field must have a numeric value.");
        }

        private void addPartMinTextBox_Validated(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Min field must have a numeric value.");
        }

        //adding validation for the Machine ID field in case of InHouse radio button is checked
            private void addPartMachineCompanyTextBox_Validated(object sender, EventArgs e)
        {
            if (addPartInHouseRadio.Checked)
            {
                ValidateNumericInput(sender, "The Machine ID field must have a numeric value");
            }
            else if (addPartOutsourcedRadio.Checked)
            {
                ValidateCompanyNameField();
            }
        }


        //changing the field composition depending on the radio click
        private void outsourcedRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);
        }

        private void inHouseRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);
        }

        private void changeLabelOnRadioClick(object sender, EventArgs e)
        {
            if (addPartOutsourcedRadio.Checked)
            {
                addPartMachineCompanyLabel.Text = "Company Name";
            }
            else
            {
                addPartMachineCompanyLabel.Text = "        Machine ID";
            }
        }

        //function for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
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

    }
}