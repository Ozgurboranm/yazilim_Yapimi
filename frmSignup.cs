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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
        sqlconnection connection = new sqlconnection();
        private void btnSignup_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into tbl_Login (KullaniciAd,KullaniciSoyad,KullaniciAdi,KullaniciSifre,KullaniciTc,KullaniciTelefon,KullaniciEmail,KullaniciAddress) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.connection1());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", txtUsername.Text);
            command.Parameters.AddWithValue("@p4", txtPassword.Text);
            command.Parameters.AddWithValue("@p5", mtbTC.Text);
            command.Parameters.AddWithValue("@p6", mtbPhone.Text);
            command.Parameters.AddWithValue("@p7", txtEmail.Text);
            command.Parameters.AddWithValue("@p8", txtAddress.Text);
            command.ExecuteNonQuery();
            connection.connection1().Close();
            MessageBox.Show("Your registration has been successful!");
        }
    }
}
