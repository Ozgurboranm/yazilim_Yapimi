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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        sqlconnection connection = new sqlconnection();
        private void btnSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup fr = new frmSignup();
            fr.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand ("Select * From tbl_Login Where KullaniciAdi=@p1 and KullaniciSifre=@p2",connection.connection1());
            command.Parameters.AddWithValue("@p1", txtusername.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Calendar calendar = new Calendar();
                calendar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
            connection.connection1().Close();
        }
    }
}
