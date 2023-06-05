using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        SqlConnection connection = new SqlConnection("Data Source = Ozgur\\SQLEXPRESS;Initial Catalog = yazilim_Yapimi;Integrated Security = True");
        private void frmDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yazilim_YapimiDataSet.tbl_Event' table. You can move, or remove it, as needed.
            this.tbl_EventTableAdapter.Fill(this.yazilim_YapimiDataSet.tbl_Event);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tbl_EventTableAdapter.Fill(this.yazilim_YapimiDataSet.tbl_Event);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tbl_Event (Date,Event) values (@p1,@p2)", connection);
            command.Parameters.AddWithValue("@p1", tbDate.Text);
            command.Parameters.AddWithValue("@p2", tbEvent.Text);
            command.ExecuteNonQuery();
            connection.Close();
            clean();
            MessageBox.Show("Event saved!");
        }

        void clean()
        {
            tbDate.Text = "";
            tbEvent.Text = "";
            tbDate.Focus();
        }
        private void btnCean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            tbDate.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            tbEvent.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand commanddelte = new SqlCommand("Delete From tbl_Event Where Date=@d1", connection);
            commanddelte.Parameters.AddWithValue("@d1", tbDate.Text);
            commanddelte.ExecuteNonQuery();
            connection.Close();
            clean();
            MessageBox.Show("Event deleted!");
        }
    }
}
