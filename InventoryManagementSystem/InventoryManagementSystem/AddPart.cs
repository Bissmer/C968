using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementSystem
{
    public partial class addPart : Form
    {
        public addPart()
        {
            InitializeComponent();
        }

        //saving information on Save button click in Add part form
        private void saveAddPartBtn_Click(object sender, EventArgs e)
        {
            int partId = int.Parse(addPartIdtTextBox.Text);
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
                Part.Parts.Add(outsourcedPart);
                this.Close();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }

            if (addPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                //added this for testing purpose, this function should go to Inventory then
                Part.Parts.Add(inhousePart);
                this.Close();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }

        }

        //changing the field composition depending on the radio click
        private void outsourcedRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineCompanyLabel.Text = "Company Name";
        }

        private void inHouseRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineCompanyLabel.Text = "Machine ID";
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
        }

        private void addPartMinTextBox_Validating(object sender, EventArgs e)
        {
            if (!IsNumeric(addPartMinTextBox.Text))
            {
                MessageBox.Show("The Min field must have a numeric value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addPartMinTextBox.Clear();
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

    }
}