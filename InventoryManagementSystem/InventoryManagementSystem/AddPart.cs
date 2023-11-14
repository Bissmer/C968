using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void changeLabelOnRadioClick(object sender, EventArgs e)
        {
            if (addPartOutsourcedRadio.Checked)
            {
                addPartMachineCompanyLabel.Text = "Company Name";
                addPartMachineCompanyTextBox.Clear();
            }
            else
            {
                addPartMachineCompanyLabel.Text = "        Machine ID";
                addPartMachineCompanyTextBox.Clear();
            }
        }
        //saving information on Save button click in Add part form
        private void saveAddPartBtn_Click(object sender, EventArgs e)
        {
            int nextPartId = Inventory.GetNextPartId();
            int partId = nextPartId;
            string name = addPartNameTextBox.Text;
            string companyName = addPartOutsourcedRadio.Checked ? addPartMachineCompanyTextBox.Text : String.Empty;
            int machineID;
            int inStock;
            decimal price;
            int max;
            int min;



            inStock = int.Parse(addPartInventoryTextBox.Text);
            price = decimal.Parse(addPartPriceTextBox.Text);
            max = int.Parse(addPartMaxTextBox.Text);
            min = int.Parse(addPartMinTextBox.Text);
            machineID = int.Parse(addPartOutsourcedRadio.Checked ? "0" : addPartMachineCompanyTextBox.Text);



            if (addPartOutsourcedRadio.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                //added this for testing purpose, this should go to Inventory then
                Inventory.getAllParts().Add(outsourcedPart);
                this.Close();
                mainForm.Show();

            }

            if (addPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                //added this for testing purpose, this function should go to Inventory then
                Inventory.getAllParts().Add(inhousePart);
                this.Close();
                mainForm.Show();
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

        //fields validation
        private void addPartInventoryTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(addPartInventoryTextBox.Text))
            {
                MessageBox.Show("The Invenrory field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartInventoryTextBox.Clear();
                addPartInventoryTextBox.Focus();
            }
        }

        private void addPartPriceTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(addPartPriceTextBox.Text))
            {
                MessageBox.Show("The Price field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartPriceTextBox.Clear();
                addPartPriceTextBox.Focus();
            }
        }

        private void addPartMaxTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(addPartMaxTextBox.Text))
            {
                MessageBox.Show("The Max field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartMaxTextBox.Clear();
                addPartMaxTextBox.Focus();
            }
            if ((IsNumeric(addPartMaxTextBox.Text) && (IsNumeric(addPartMinTextBox.Text)) && ((int.Parse(addPartMaxTextBox.Text) < int.Parse(addPartMinTextBox.Text)))))
            {
                MessageBox.Show("The Max value must be more than the Min value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartMaxTextBox.Focus();
            }

        }

        private void addPartMinTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(addPartMinTextBox.Text))
            {
                MessageBox.Show("The Min field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartMinTextBox.Clear();
                addPartMinTextBox.Focus();
            }
            if ((IsNumeric(addPartMinTextBox.Text)) && ((int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))))
            {
                MessageBox.Show("The Min value must be less than the Max value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartMinTextBox.Focus();
            }
        }


        //adding validation for the Machine ID field in case of InHouse radio button is checked
        private void addPartMachineCompanyTextBox_Validating(object sender, EventArgs e)
        {
            if (addPartInHouseRadio.Checked)
            {
                if (!IsNumeric(addPartMachineCompanyTextBox.Text))
                {
                    MessageBox.Show("The Machine ID field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addPartMachineCompanyTextBox.Clear();
                    addPartMachineCompanyTextBox.Focus();
                }
            }
           
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