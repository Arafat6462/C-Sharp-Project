using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X
{
    public partial class Uc_Admin_EmployeeDetails : UserControl
    {
        public Uc_Admin_EmployeeDetails()
        {
            InitializeComponent();
        }
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void Uc_Admin_EmployeeDetails_Load(object sender, EventArgs e)
        {
            string query = "select * from employee";
            DataSet dataSet = databaseConnection.getData(query);
            DataGridView_EmployeeDetails.DataSource = dataSet.Tables[0];
        }
    }
}
