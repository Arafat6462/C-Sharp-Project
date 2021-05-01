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
    public partial class Uc_Admin_RemoveEmployee : UserControl
    {
        public Uc_Admin_RemoveEmployee()
        {
            InitializeComponent();
        }


        // create object and load data.
        DatabaseConnection databaseConnection = new DatabaseConnection();
        private void loadData()
        {
            string query = "select * from employee";
            DataSet dataSet = databaseConnection.getData(query);
            DataGridView__RemoveEmployee.DataSource = dataSet.Tables[0];
        }


        private void Uc_Admin_RemoveEmployee_Load(object sender, EventArgs e)
        {
            loadData();   
        }

        private void btn_DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txt_searachID.Text != "")
            {
                if (MessageBox.Show("Are you sure..?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = "delete from employee where eid = " + txt_searachID.Text + "";
                    databaseConnection.setData(query, "Remove employee successfully.");
                    loadData();
                }
            }

        }
    }
}
