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
using System.Xml.Linq;

namespace yazilim_Yapimi
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }
        SqlConnection connection = new SqlConnection("Data Source = Ozgur\\SQLEXPRESS;Initial Catalog = yazilim_Yapimi;Integrated Security = True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbDate.Text == "" || tbEvent.Text == "")
            {
                MessageBox.Show(" Cannot be Empty !");
                return;
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbDate.Text == "" || tbEvent.Text == "")
            {
                MessageBox.Show(" Cannot be Empty !");
                return;
            }
            connection.Open();
            SqlCommand commanddelte = new SqlCommand("Delete From tbl_Event Where Date=@d1", connection);
            commanddelte.Parameters.AddWithValue("@d1", tbDate.Text);
            commanddelte.ExecuteNonQuery();
            connection.Close();
            clean();
            MessageBox.Show("Event deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbDate.Text == "" || tbEvent.Text == "")
            {
                MessageBox.Show(" Cannot be Empty !");
                return;
            }
            connection.Open();
            SqlCommand commanupdate = new SqlCommand("Update tbl_Event Set Date=@u1,Event=@u2 Where Id=@u3", connection);
            commanupdate.Parameters.AddWithValue("@u1",tbDate.Text);
            commanupdate.Parameters.AddWithValue("@u2",tbEvent.Text);
            commanupdate.Parameters.AddWithValue("@u3",label3.Text);
            commanupdate.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Event Update!");
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            this.tbl_EventTableAdapter3.Fill(this.yazilim_YapimiDataSet3.tbl_Event);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            label3.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            tbDate.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            tbEvent.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tbl_EventTableAdapter3.Fill(this.yazilim_YapimiDataSet3.tbl_Event);
        }
    }
}
