using System;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //initialized datasourse for test purpose
            var partTable = new BindingSource();
            partTable.DataSource = Part.Parts;
            partsTableGrid.DataSource = partTable;
        }

        private void addPartsMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var part = new addPart();
            part.ShowDialog();
        }

        private void modifyPartsMainButton_Click(object sender, EventArgs e)
        {
            if (partsTableGrid.CurrentRow.DataBoundItem.GetType() == typeof(InventoryManagementSystem.InHouse))
            {
                InHouse inhousePart = (InHouse)partsTableGrid.CurrentRow.DataBoundItem;
                new ModifyPart(inhousePart).ShowDialog();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)partsTableGrid.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }
        //enable modify button when row is selected
        private void partsTableGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (partsTableGrid.SelectedRows.Count > 0)
            {
                modifyPartsMainButton.Enabled = true;
            }
            else
            {
                modifyPartsMainButton.Enabled = false;
            }
        }
    }
}

