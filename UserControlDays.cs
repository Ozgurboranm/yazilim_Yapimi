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
using System.Globalization;

namespace yazilim_Yapimi
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbdays.Text = numday + ""; 
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
        private void displayEvent()
        {
            sqlconnection connection = new sqlconnection();
            SqlCommand command = new SqlCommand("Select (*) From tbl_Event Where Date)", connection.connection1());
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read()) 
            {
                lbevent.Text = reader["event"].ToString();
            }
            reader.Close();
        }
    }
}
