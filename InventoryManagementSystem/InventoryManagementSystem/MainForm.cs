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
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();

            //initialized datasourse for test purpose
            var partTable = new BindingSource();
            partTable.DataSource = Part.Parts;
            partsTableGrid.DataSource = partTable;
        }

        private void addPartsMainButton_Click(object sender, EventArgs e)
        {
            var part = new addPart();
            part.ShowDialog();
        }
    }
}
