using System;
using System.Collections;
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
    public partial class Uc_Admin_Dashboard : UserControl
    {
        public Uc_Admin_Dashboard()
        {
            InitializeComponent();
        }
        Dashboard_Salary_Data dashboard_Salary_Data = new Dashboard_Salary_Data();
        private object databaseConnection;


        private void Progressbar_Capital_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Uc_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            LoadAdminDashboardData();

        }

        private void txt_TotalEmployee_Click(object sender, EventArgs e)
        {
 
        }










        // load all data for admin dashboard
       public void LoadAdminDashboardData()
        {
            // capital in dashboard
            double d = (Dashboard_Salary_Data.TotalAmount * 100) / 500000;
            Progressbar_Capital.Value = Convert.ToInt32(d);
            Progressbar_Capital_txt.Text = Dashboard_Salary_Data.TotalAmount.ToString();

            // salary in dashboard

            int Salary = 0;
            dashboard_Salary_Data.loadDAtaToArrayList();
            for (int i = 0; i < dashboard_Salary_Data.IDList.Count; i++)
            {
                Salary += Convert.ToInt32(dashboard_Salary_Data.SalaryList[i]);
            }
            Progressbar_Salary.Value = (Salary * 100) / 500000;
            Progressbar_Salary_txt.Text = Salary.ToString(); // value of text
            txt_TotalEmployee.Text = dashboard_Salary_Data.IDList.Count.ToString(); // total employee




            // room price for dashboard
            string query = "select price from rooms";
            DatabaseConnection databaseConnection = new DatabaseConnection();
            DataSet dataSet = databaseConnection.getData(query);
            int roomPrice = 0;
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                roomPrice += Convert.ToInt32(dataSet.Tables[0].Rows[i][0].ToString());
            }
            Progressbar_Rent.Value = (roomPrice * 100) / 500000;
            Progressbar_Rent_txt.Text = roomPrice.ToString(); // value of text
            txt_TotalRoom.Text = dataSet.Tables[0].Rows.Count.ToString(); // total rooms

            //
            DataSet dataSetcustomer = databaseConnection.getData("select cid from customer");
            txt_TotalCustomer.Text = dataSetcustomer.Tables[0].Rows.Count.ToString(); // total customer


        }
    }
}
