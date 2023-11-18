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

        private void cancelModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            mainForm.ShowDialog();
        }

        private void saveModifyPartBtn_Click(object sender, System.EventArgs e)
        {
            int partId = int.Parse(modifyPartIdTextBox.Text);
            string name = modifyPartNameTextBox.Text;
            string companyName = modifyPartOutsourcedRadio.Checked ? modifyPartMachineCompanyTextBox.Text : String.Empty;
            int machineID = int.Parse(modifyPartOutsourcedRadio.Checked ? "0" : modifyPartMachineCompanyTextBox.Text);
            int inStock = int.Parse(modifyPartIdTextBox.Text);
            decimal price = decimal.Parse(modifyPartPriceTextBox.Text);
            int max = int.Parse(modifyPartMinTextBox.Text);
            int min = int.Parse(modifyPartMaxTextBox.Text);


            if (modifyPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                Inventory.updatePart(partId, inhousePart);
            }
            else if (modifyPartOutsourcedRadio.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                Inventory.updatePart(partId, outsourcedPart);
            }

            this.Close();
            mainForm.Show();
            mainForm.partsGridView.Update();
            mainForm.partsGridView.Refresh();
        }


        //fields validation
        private void modifyPartInventoryTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(modifyPartInventoryTextBox.Text))
            {
                MessageBox.Show("The Invenrory field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartInventoryTextBox.Clear();
                modifyPartInventoryTextBox.Focus();
            }
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
            if (!IsNumeric(modifyPartMaxTextBox.Text))
            {
                MessageBox.Show("The Max field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartMaxTextBox.Clear();
                modifyPartMaxTextBox.Focus();
            }

            if ((IsNumeric(modifyPartMaxTextBox.Text) && (IsNumeric(modifyPartMinTextBox.Text)) &&
                 ((int.Parse(modifyPartMaxTextBox.Text) < int.Parse(modifyPartMinTextBox.Text)))))
            {
                MessageBox.Show("The Max value must be more than the Min value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartMaxTextBox.Focus();
            }
        }

        private void modifyPartMinTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(modifyPartMinTextBox.Text))
            {
                MessageBox.Show("The Min field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartMinTextBox.Clear();
                modifyPartMinTextBox.Focus();
            }

            if ((IsNumeric(modifyPartMinTextBox.Text)) &&
                ((int.Parse(modifyPartMinTextBox.Text) > int.Parse(modifyPartMaxTextBox.Text))))
            {
                MessageBox.Show("The Min value must be less than the Max value.", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                modifyPartMinTextBox.Focus();
            }
        }

        //function for validating input for numeric val
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
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
