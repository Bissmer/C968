using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace InventoryManagementSystem
{
    public partial class addPart : Form
    {
        public MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

        public addPart(int partID)
        {
            InitializeComponent();
            addPartIdtTextBox.Text = partID.ToString();
            addPartIdtTextBox.ReadOnly = true;
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

                Part newPart = addPartOutsourcedRadio.Checked
                    ? (Part)new Outsourced(partId, name, price, inStock, max, min, companyName)
                    : new InHouse(partId, name, price, inStock, max, min, machineID);

                Inventory.getAllParts().Add(newPart);
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
        //common function for numeric input validation
        private void ValidateNumericInput(object sender, string errorMessage)
        {
            if (!IsNumeric(((TextBox)sender).Text))
            {
                MessageBox.Show(errorMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Clear();
                ((TextBox)sender).Focus();
            }
        }
        //validation of fields
        private void addPartInventoryTextBox_Validating(object sender, EventArgs e)
        {
           ValidateNumericInput(sender, "The Inventory field must have a numeric value.");

        }

        private void addPartPriceTextBox_Validating(object sender, EventArgs e)
        {
            decimal value;
            if (!Decimal.TryParse(addPartPriceTextBox.Text, out value))
            {
                MessageBox.Show("The Price field must have a decimal value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                addPartPriceTextBox.Clear();
                addPartPriceTextBox.Focus();
            }
        }
        private void addPartMaxTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Max field must have a numeric value.");
        }

        private void addPartMinTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Min field must have a numeric value.");
        }

        //validation for the Min and Max fields
      

        //adding validation for the Machine ID field in case of InHouse radio button is checked
            private void addPartMachineCompanyTextBox_Validating(object sender, EventArgs e)
        {
            if (addPartInHouseRadio.Checked)
            {
                ValidateNumericInput(sender, "The Machine ID field must have a numeric value");
            }
        }

        private void changeLabelOnRadioClick(object sender, EventArgs e)
        {
           addPartMachineCompanyLabel.Text = addPartOutsourcedRadio.Checked ? "Company Name" : "        Machine ID";
           addPartMachineCompanyTextBox.Clear();
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


        //function for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void cancelAddPartBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}