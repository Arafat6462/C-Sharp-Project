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
    public partial class Uc_Admin_Salary : UserControl
    {
        public Uc_Admin_Salary()
        {
            InitializeComponent();
        }



        Dashboard_Salary_Data dashboard_Salary_Data = new Dashboard_Salary_Data();

        int Top = 100;
        int Left = 40;
        int Count = 0;
        int totalSalary = 0; // all salary

        void StatusButton(int Left, int Top)
        {
            /*Button button = new Button();
            this.Controls.Add(button);*/
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Admin_Salary));

            btn_Pay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Controls.Add(btn_Pay);

            this.btn_Pay.Checked = true;

            this.btn_Pay.Animated = true;
            this.btn_Pay.BorderColor = System.Drawing.Color.White;
            this.btn_Pay.BorderRadius = 15;
            this.btn_Pay.BorderThickness = 1;
            this.btn_Pay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_Pay.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btn_Pay.CheckedState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Pay.CheckedState.FillColor2 = System.Drawing.Color.DarkSlateGray;
            this.btn_Pay.CheckedState.Parent = this.btn_Pay;
            //this.btn_Pay.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("checked")));
            this.btn_Pay.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Pay.CustomImages.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_Pay.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Pay.CustomImages.Parent = this.btn_Pay;
            this.btn_Pay.FillColor = System.Drawing.Color.Empty;
            this.btn_Pay.FillColor2 = System.Drawing.Color.Empty;
            this.btn_Pay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay.ForeColor = System.Drawing.Color.White;
            this.btn_Pay.HoverState.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Pay.HoverState.Parent = this.btn_Pay;
            this.btn_Pay.Location = new System.Drawing.Point(Left, Top);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.ShadowDecoration.Parent = this.btn_Pay;
            this.btn_Pay.Size = new System.Drawing.Size(150, 40);
            this.btn_Pay.TabIndex = 5;
            this.btn_Pay.Text = "Checked";
            this.btn_Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Pay.TextOffset = new System.Drawing.Point(0, 0);
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);


        }

        // place all input
        void AllInputDesign(int Left, int Top, string text)
        {
            Label label2 = new Label();
            this.Controls.Add(label2);

            // label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(Left, Top);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label_Dynamic";
            label2.Size = new System.Drawing.Size(160, 40);
            label2.TabIndex = 1;
            label2.Text = text;
            label2.ForeColor = Color.White;
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        }
        private void btn_Creat_lable_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            Top = 100;
          
            for (int i = 0; i <dashboard_Salary_Data.IDList.Count; i++)
            {
                StatusButton(1165, Top);
                Top += 50;
                totalSalary +=Convert.ToInt32(dashboard_Salary_Data.SalaryList[i]);
                txt_Total_salary.Text = "Total Salary : "+totalSalary.ToString();
             }
        }

      
         
        private void btn_PayAll_Click(object sender, EventArgs e)
        {
            if(Dashboard_Salary_Data.TotalAmount >= totalSalary)
            {
                  MessageBox.Show("Payment success", "success...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard_Salary_Data.TotalAmount -= totalSalary;
            }
            else
            MessageBox.Show("insufficient balance", "Warning...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
 
        }

        private void Uc_Admin_Salary_Load(object sender, EventArgs e)
        {
            dashboard_Salary_Data.loadDAtaToArrayList(); // parse all data
            for (int i = 0; i <dashboard_Salary_Data.IDList.Count; i++)
            {
                AllInputDesign(Left, Top, dashboard_Salary_Data.IDList[i].ToString());
                AllInputDesign(415, Top, dashboard_Salary_Data.NameList[i].ToString());
                AllInputDesign(790, Top, dashboard_Salary_Data.SalaryList[i].ToString());


                Top += 50;
            }
        }

        private void txt_Total_salary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
