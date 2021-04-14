using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X
{
    class DatabaseConnection
    {
        protected SqlConnection GetSqlConnection()
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "data source = DESKTOP-3D0MFQ3\\ARAFAT;database=myHotel;integrated security = True";
                return connection;
            }

            public DataSet getData(string query) // get data from database.
            {
                SqlConnection connection = GetSqlConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }

            public void setData(string query, string message) // insert delete update.
            {
                SqlConnection connection = GetSqlConnection();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("'" + message + "'", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
    }
}
