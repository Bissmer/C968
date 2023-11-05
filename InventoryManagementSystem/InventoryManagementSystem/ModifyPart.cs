using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ModifyPart : Form
    {
        private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
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

    }
}
