using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yazilim_Yapimi
{
    class sqlconnection
    {
        public SqlConnection connection1() 
        {
            SqlConnection connection = new SqlConnection("Data Source = Ozgur\\SQLEXPRESS;Initial Catalog = yazilim_Yapimi;Integrated Security = True");
            connection.Open();
            return connection;
        }
    }
}
