using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Inventory.ExampleItems();
            //initialized datasourse for test purpose
            var partTable = new BindingSource();
            partTable.DataSource = Inventory.getAllParts();
            partsGridView.DataSource = partTable;

            var productTable = new BindingSource();
            productTable.DataSource = Inventory.getProducts();
            productsGridView.DataSource = productTable;
        }

        private void addPartsMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int nextPartID = Inventory.GetNextPartId();
            var part = new addPart(nextPartID);
            part.ShowDialog();
            partsGridView.Refresh();
        }

        private void modifyPartsMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (partsGridView.CurrentRow.DataBoundItem.GetType() == typeof(InventoryManagementSystem.InHouse))
            {
                InHouse inhousePart = (InHouse)partsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)partsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }
        //enable modify button when row is selected
        private void partsTableGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count > 0)
            {
                mainFormModifyPartsButton.Enabled = true;
            }
            else
            {
                mainFormModifyPartsButton.Enabled = false;
            }
        }


    }
}

