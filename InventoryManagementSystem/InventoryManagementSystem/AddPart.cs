using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class addPart : Form
    {
        public addPart()
        {
            InitializeComponent();
        }

        private void saveAddPartBtn_Click(object sender, EventArgs e)
        {
            string partId = idAddPartTextBox.Text;
            string name = nameAddPartTextBox.Text;
            string inStock = inventoryAddPartTextBox.Text;
            string price = priceAddPartTextBox.Text;
            string max = maxAddPartTextBox.Text;
            string min = minAddPartTextBox.Text;
            string companyName = outsourcedRadioAddPart.Checked ? companyNameAddPartTextBox.Text : String.Empty;

            if (outsourcedRadioAddPart.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                //added this for testing purpose, this should be go to Inventory then
                Part.Parts.Add(outsourcedPart);
                this.Close();
            }
        }

        private void outsourcedRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineIdLabel.Visible = false;
            machineIdAddPartTextBox.Visible = false;
            companyNameLabel.Visible = true;
            companyNameAddPartTextBox.Visible = true;
        }

        private void inHouseRadioAddPart_CheckedChanged(object sender, EventArgs e)
        {
            machineIdLabel.Visible = true;
            machineIdAddPartTextBox.Visible = true;
            companyNameLabel.Visible = false;
            companyNameAddPartTextBox.Visible = false;
        }
    }
}
