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
    public partial class EventForm : Form
    {
        sqlconnection connection = new sqlconnection();



        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtdate.Text =Calendar.static_month + "-" + UserControlDays.static_day + "-" + Calendar.static_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtevent.Text == "")
            {
                MessageBox.Show(" Cannot be Empty !");
                return;
            }
            SqlCommand command = new SqlCommand("insert into tbl_Event (Date,Event) values (@p1,@p2)", connection.connection1());
            command.Parameters.AddWithValue("@p1", txtdate.Text);
            command.Parameters.AddWithValue("@p2", txtevent.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Saved!");
            connection.connection1().Close();
        }
    }
}
