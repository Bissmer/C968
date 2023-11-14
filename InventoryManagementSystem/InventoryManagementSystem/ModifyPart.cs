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
            int machineID;
            int inStock;
            decimal price;
            int max;
            int min;



            inStock = int.Parse(modifyPartIdTextBox.Text);
            price = decimal.Parse(modifyPartPriceTextBox.Text);
            max = int.Parse(modifyPartMinTextBox.Text);
            min = int.Parse(modifyPartMaxTextBox.Text);
            machineID = int.Parse(modifyPartOutsourcedRadio.Checked ? "0" : modifyPartMachineCompanyTextBox.Text);


            if (modifyPartOutsourcedRadio.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(partId, name, price, inStock, max, min, companyName);
                //added this for testing purpose, this should go to Inventory then
                Inventory.updatePart(partId, outsourcedPart);
                modifyPartInHouseRadio.Checked = true;
            }

            if (modifyPartInHouseRadio.Checked)
            {
                InHouse inhousePart = new InHouse(partId, name, price, inStock, max, min, machineID);
                //added this for testing purpose, this function should go to Inventory then
                Inventory.updatePart(partId, inhousePart);
            }
            this.Close();
            mainForm.Show();
            mainForm.partsGridView.Update();
            mainForm.partsGridView.Refresh();


        }

        
    }
}
