using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPart : Form
    {
        public MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

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
        }

        private void saveModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            int partId = int.Parse(modifyPartIdTextBox.Text);
            string name = modifyPartNameTextBox.Text;
            string companyName = modifyPartOutsourcedRadio.Checked ? modifyPartMachineCompanyTextBox.Text : String.Empty;
            int machineID = int.Parse(modifyPartOutsourcedRadio.Checked ? "0" : modifyPartMachineCompanyTextBox.Text);
            int inStock = int.Parse(modifyPartInventoryTextBox.Text);
            decimal price = decimal.Parse(modifyPartPriceTextBox.Text);
            int max = int.Parse(modifyPartMaxTextBox.Text);
            int min = int.Parse(modifyPartMinTextBox.Text);


            if (modifyPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                Inventory.updatePart(partId, inhousePart);
                modifyPartInHouseRadio.Checked = true;
            }
            else if (modifyPartOutsourcedRadio.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                Inventory.updatePart(partId, outsourcedPart);
                modifyPartOutsourcedRadio.Checked = true;
            }

            if (max < min)
            {
                MessageBox.Show("The Max value must be higher than the Min value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory should be in range of min/max", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
            mainForm.Show();
            mainForm.partsGridView.Update();
            mainForm.partsGridView.Refresh();
        }

        private void cancelModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }


        //add valid for ModifyPart
        //fields validation
        private void modifyPartInventoryTextBox_Validating(object sender, EventArgs e)
        {
            ValidateNumericInput(sender, "The Inventory field must have a numeric value.");
        }

        private void modifyPartPriceTextBox_Validating(object sender, EventArgs e)
        {
            decimal value;
            if (!Decimal.TryParse(modifyPartPriceTextBox.Text, out value))
            {
                MessageBox.Show("The Price field must have a decimal value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartPriceTextBox.Clear();
                modifyPartPriceTextBox.Focus();
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
        }

        //function for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }
        private void ValidateNumericInput(object sender, string errorMessage)
        {
            if (!IsNumeric(((TextBox)sender).Text))
            {
                MessageBox.Show(errorMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Clear();
                ((TextBox)sender).Focus();
            }
        }

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


    }
}
