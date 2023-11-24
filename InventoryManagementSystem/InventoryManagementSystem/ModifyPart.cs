using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPart : Form
    {
        public MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        private ErrorProvider _errorProvider;

        //constructor for the Inhouse radio checked
        public ModifyPart(InHouse inHousePart)
        {
            InitializeComponent();
            modifyPartIdTextBox.Text = inHousePart.PartId.ToString();
            modifyPartNameTextBox.Text = inHousePart.Name;
            modifyPartInventoryTextBox.Text = inHousePart.InStock.ToString();
            modifyPartPriceTextBox.Text = inHousePart.Price.ToString();
            modifyPartMaxTextBox.Text = inHousePart.Max.ToString();
            modifyPartMinTextBox.Text = inHousePart.Min.ToString();
            modifyPartMachineCompanyTextBox.Text = inHousePart.MachineID.ToString();

            modifyPartInHouseRadio.Checked = true;
            this.cancelModifyPartBtn.CausesValidation = false;
            this._errorProvider = new ErrorProvider();
        }

        //constructor for the Outsourced radio checked
        public ModifyPart(Outsourced outsourcedPart)
        {
            InitializeComponent();
            modifyPartIdTextBox.Text = outsourcedPart.PartId.ToString();
            modifyPartNameTextBox.Text = outsourcedPart.Name;
            modifyPartInventoryTextBox.Text = outsourcedPart.InStock.ToString();
            modifyPartPriceTextBox.Text = outsourcedPart.Price.ToString();
            modifyPartMaxTextBox.Text = outsourcedPart.Max.ToString();
            modifyPartMinTextBox.Text = outsourcedPart.Min.ToString();
            modifyPartMachineCompanyTextBox.Text = outsourcedPart.CompanyName;

            modifyPartOutsourcedRadio.Checked = true;
            this.cancelModifyPartBtn.CausesValidation = false;
            this._errorProvider = new ErrorProvider();
        }

        private void saveModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                int partId = int.Parse(modifyPartIdTextBox.Text);
                string name = modifyPartNameTextBox.Text;
                string companyName = modifyPartOutsourcedRadio.Checked ? modifyPartMachineCompanyTextBox.Text : String.Empty;
                int machineID = int.Parse(modifyPartOutsourcedRadio.Checked ? "0" : modifyPartMachineCompanyTextBox.Text);
                int inStock = int.Parse(modifyPartInventoryTextBox.Text);
                decimal price = decimal.Parse(modifyPartPriceTextBox.Text);
                int max = int.Parse(modifyPartMaxTextBox.Text);
                int min = int.Parse(modifyPartMinTextBox.Text);


                if (!ValidateNameField()) return;
                if (!ValidateMinMax(min, max)) return;
                if (!IsInStockWithinRange(inStock, min, max)) return;
                if (!ValidateCompanyNameField()) return;

                Part updatedPart;
                if (modifyPartInHouseRadio.Checked)
                {
                    updatedPart = new InHouse(partId, name, price, inStock, max, min, machineID);
                }
                else if (modifyPartOutsourcedRadio.Checked)
                {
                    updatedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                }
                else
                {
                    return;
                }

                Inventory.updatePart(partId, updatedPart);

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

        private void cancelModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }


        //Modify Part fields validation
        private bool ValidateNameField()
        {
            if (string.IsNullOrWhiteSpace(modifyPartNameTextBox.Text))
            {
                SetTextBoxErrorState(modifyPartNameTextBox, "The Name field cannot be empty.");
                return false;
            }
            else
            {
                ResetTextBoxState(modifyPartNameTextBox);
                return true;
            }
        }

        private bool ValidateCompanyNameField()
        {
            if (modifyPartOutsourcedRadio.Checked)
            {
                if (string.IsNullOrWhiteSpace(modifyPartMachineCompanyTextBox.Text))
                {
                    SetTextBoxErrorState(modifyPartMachineCompanyTextBox, "The Company Name field cannot be empty.");
                    return false;
                }
                else
                {
                    ResetTextBoxState(modifyPartMachineCompanyTextBox);
                    return true;
                }
            }
            return true;
        }

        private void modifyPartNameTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNameField();
        }

        private void modifyPartInventoryTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Inventory field must have a numeric value.");
        }

        private void modifyPartPriceTextBox_Validating(object sender, EventArgs e)
        {
            decimal value;
            if (!Decimal.TryParse(modifyPartPriceTextBox.Text, out value))
            {
                SetTextBoxErrorState(modifyPartPriceTextBox, "The Price field must have a numeric value.");
            }
            else
            {
                ResetTextBoxState(modifyPartPriceTextBox);
            }
        }

        private void modifyPartMaxTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Max field must have a numeric value.");
        }

        private void modifyPartMinTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Min field must have a numeric value.");
        }

        private void modifyPartMachineCompanyTextBox_Validating(object sender, EventArgs e)
        {
            if (modifyPartInHouseRadio.Checked)
            {
                ValidateNumericInput(sender, "The Machine ID field must have a numeric value");
            }
            else if (modifyPartOutsourcedRadio.Checked)
            {
                ValidateCompanyNameField();
            }
        }

        //Logic for changing the label on radio button click
        private void changeLabelOnRadioClick(object sender, EventArgs e)
        {
            if (modifyPartOutsourcedRadio.Checked)
            {
                modifyPartPartMachineCompanyLabel.Text = "Company Name";
            }
            else
            {
                modifyPartPartMachineCompanyLabel.Text = "        Machine ID";
            }
        }

        private void modifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);
        }

        private void modifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);
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

        //functions for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }
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

    }
}
