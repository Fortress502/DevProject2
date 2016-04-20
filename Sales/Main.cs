using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddInventoryRecord(object sender, EventArgs e)
        {
            AddInventoryRecord AddInvRecordFrm = new AddInventoryRecord();
            AddInvRecordFrm.Show();
            //this.Close();
        }

        private void btnEditInventoryRecord(object sender, EventArgs e)
        {

        }

        private void btnCheckStockLevel(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport(object sender, EventArgs e)
        {

        }
    }
}
