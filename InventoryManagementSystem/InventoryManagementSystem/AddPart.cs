using System;
using System.Windows.Forms;

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
            string machineID = addPartInHouseRadio.Checked ? addPartMachineCompanyTextBox.Text : String.Empty;
            int inStock;
            decimal price;
            int max;
            int min;

            try
            {
                inStock = int.Parse(addPartInventoryTextBox.Text);
                price = decimal.Parse(addPartPriceTextBox.Text);
                min = int.Parse(addPartMinTextBox.Text);
                max = int.Parse(addPartMaxTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Input error: Inventory, Price, Min, Max fields should have numeric values");
            }

            inStock = int.Parse(addPartInventoryTextBox.Text);
            price = decimal.Parse(addPartPriceTextBox.Text);
            min = int.Parse(addPartMinTextBox.Text);
            max = int.Parse(addPartMaxTextBox.Text);


            if (addPartOutsourcedRadio.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                //added this for testing purpose, this should go to Inventory then
                Part.Parts.Add(outsourcedPart);
                this.Close();
            }

            if (addPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                //added this for testing purpose, this function should go to Inventory then
                Part.Parts.Add(inhousePart);
                this.Close();
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

    }
}
