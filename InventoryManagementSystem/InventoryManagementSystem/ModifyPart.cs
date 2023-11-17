using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPart : Form
    {
        public MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
        public ModifyPart()
        {
            InitializeComponent();
        }

        //constructor for the Inhouse radio checked
        public ModifyPart(InHouse inHousePart) : this()
        {
            InitializeComponent();
            SetCommonFields(inHousePart.PartId, inHousePart.Name, inHousePart.InStock, inHousePart.Price, inHousePart.Max, inHousePart.Min);
            modifyPartMachineCompanyTextBox.Text = inHousePart.MachineID.ToString();
            modifyPartInHouseRadio.Checked = true;
        }

        //constructor for the Outsourced radio checked
        public ModifyPart(Outsourced outsourcedPart)
        {
            InitializeComponent();
            SetCommonFields(outsourcedPart.PartId, outsourcedPart.Name, outsourcedPart.InStock, outsourcedPart.Price, outsourcedPart.Max, outsourcedPart.Min);
            modifyPartMachineCompanyTextBox.Text = outsourcedPart.CompanyName;
            modifyPartOutsourcedRadio.Checked = true;
        }

        private void SetCommonFields(int partId, string name, int inStock, decimal price, int max, int min)
        {
            modifyPartIdTextBox.Text = partId.ToString();
            modifyPartNameTextBox.Text = name;
            modifyPartInventoryTextBox.Text = inStock.ToString();
            modifyPartPriceTextBox.Text = price.ToString();
            modifyPartMaxTextBox.Text = max.ToString();
            modifyPartMinTextBox.Text = min.ToString();
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


                if (modifyPartInHouseRadio.Checked)
                {
                    Inventory.updatePart(partId, new InHouse(partId, name, price, inStock, max, min, machineID));
                }
                else
                {
                    Inventory.updatePart(partId, new Outsourced(partId, name, price, inStock, max, min, companyName));
                }

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

                CloseAndRefresh();

            }catch (FormatException ex)
            {
                MessageBox.Show($"Input format error: {ex.Message}", "Input Field Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        //fields validation

        private void ValidateNumericInput(object sender, string errorMessage)
        {
            if (!IsNumeric(((TextBox)sender).Text))
            {
                MessageBox.Show(errorMessage, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ((TextBox)sender).Clear();
                ((TextBox)sender).Focus();
            }
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

        //function for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }


        private void changeLabelOnRadioClick(object sender, EventArgs e)
        {
            modifyPartPartMachineCompanyLabel.Text = modifyPartOutsourcedRadio.Checked ? "Company Name" : "        Machine ID";
            
        }


        private void modifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);

        }

        private void modifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            changeLabelOnRadioClick(sender, e);
        }

        private void CloseAndRefresh()
        {
            this.Close();
            mainForm.Show();
            mainForm.partsGridView.Update();
            mainForm.partsGridView.Refresh();
        }

        private void cancelModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            mainForm.ShowDialog();
        }

    }
}
