using MySql.Data.MySqlClient;
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
    public partial class EditInventoryRecord : Form
    {

        public EditInventoryRecord()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, EventArgs e)
        {
            Main MainFrm = new Main();
            MainFrm.Show();
            this.Hide();
        }

        private void btnEditSelectedRecord(object sender, EventArgs e)
        {

        }

        private void btnNext(object sender, EventArgs e)
        {

        }

        private void btnPrevious(object sender, EventArgs e)
        {

        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLoadTable(object sender, EventArgs e)
        {
            DBConnect DB = new DBConnect();
        }
    }
}
