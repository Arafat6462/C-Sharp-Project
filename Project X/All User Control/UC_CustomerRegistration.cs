using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_X.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(string query,ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while(sdr.Read())
            {
                for(int i =0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType='" + txtRoom.Text + "' and booked='NO'";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from roooms where roomNo='" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse( ds.Tables[0].Rows[0][1].ToString());        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtContact.Text!=""&& txtNationality.Text!=""&& txtGender.Text!=""&& txtDob.Text!=""&& txtIdProof.Text!=""&& txtAddress.Text!=""&& txtCheckIn.Text!=""&& txtPrice.Text!="")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtDob.Text;
                string idproof = txtIdProof.Text;
                string address = txtAddress.Text;
                string checkin = txtCheckIn.Text;

                query = "insert into customer (cname,mobile,nationality,nationality,gender,dob,idproof,addres,checkin,roomid) values ('"+name+"','"+mobile+"','"+national+ "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "','"+rid+"') update rooms set booked='YES' where roomNo='"+txtRoomNo.Text+"'";
                fn.setData(query, "Room No" + txtRoomNo.Text + "Allocation Successful");
                clearAll();
            }
            else
            {
                MessageBox.Show("All fields are mendatory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
