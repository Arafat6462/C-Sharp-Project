using System;
using System.Data;
using System.Windows.Forms;

namespace Project_X
{
    public partial class Uc_Admin_AddEmployee : UserControl
    {
        // database connection
        DatabaseConnection databaseConnection = new DatabaseConnection();
        string query;
        public Uc_Admin_AddEmployee()
        {
            InitializeComponent();
        }



        // get and set employee id.............. request method .....................
        public void getMaxid()
        {
            query = "select max(eid) from employee";
            DataSet dataSet = databaseConnection.getData(query);

            if (dataSet.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 eid = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                txt_ID.Text = (eid + 1).ToString();
            }
            else
            {
                txt_ID.Text = "no id found";
            }
        }


        /// ........................ clear method ...........................
        public void clearAll()
        {
            txt_name.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            radio_btn_male.Checked = false;
            radio_btn_female.Checked = false;
            txt_salary.Clear();
            txt_userName.Clear();
            txt_password.Clear();
 
        }





        private void Uc_Admin_AddEmployee_Load(object sender, EventArgs e)
        {
            getMaxid();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            // checke empty input and insert into database.
            if (txt_name.Text != "" && txt_email.Text != "" && txt_phone.Text != "" && timePick_joinningDate.Text != "" && txt_salary.Text != "" && txt_userName.Text != "" && txt_password.Text != "" && (radio_btn_female.Checked || radio_btn_male.Checked))
            {
                string name = txt_name.Text;
                string email = txt_email.Text;
                Int64 phone = Int64.Parse(txt_phone.Text);
                string joinningDate = timePick_joinningDate.Text;
                Int64 salary = Int64.Parse(txt_salary.Text);
                string username = txt_userName.Text;
                string password = txt_password.Text;
                string gender = "";
                if (radio_btn_male.Checked) gender = "Male";
                else if (radio_btn_female.Checked) gender = "Female";

                query = "insert into employee (ename,emailid,gender,phone,ejoinning,esalary,username,pass) values('"+name+"','"+email+ "','" + gender + "'," + phone+",'"+joinningDate+"',"+salary+",'"+username+"','"+password+"') ";

                // set data.
                databaseConnection.setData(query,"Employee Registration ");

                // clear all data
                clearAll();
                getMaxid(); // update instantly
            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
        }

        
         // only number allow 
        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Uc_Admin_AddEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
