using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_Yapimi
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_YapimiDataSet.tbl_Event' table. You can move, or remove it, as needed.
            this.tbl_EventTableAdapter.Fill(this.yazilim_YapimiDataSet.tbl_Event);

        }
    }
}
