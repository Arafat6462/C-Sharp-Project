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
    public partial class AdminControllerDashboard : Form
    {
        public AdminControllerDashboard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true); // for resizable windows.
        }

        private void AdminControllerDashboard_Load(object sender, EventArgs e)
        {

        }


        // for showing full left-sidebar
        private void sidebarShow_Click(object sender, EventArgs e)
        {
            // reset location and size of bode panel along with side-panel
           /* uc_settings1.Location = new Point(243, 60);
            this.uc_settings1.Size = new System.Drawing.Size(uc_settings1.Width - 180, uc_settings1.Height);
*/
            logoPicture.Visible = true;
            sidebarShow.Visible = false;
            sidebarHide.Visible = true;
            leftPanel.Visible = false;
            leftPanel.Width = 243;
            guna2Transition1.ShowSync(leftPanel);
        }

        // for hiding full left-sidebar
        private void sidebarHide_Click(object sender, EventArgs e)
        {
            // reset location and size of bode panel along with side-panel
            /*uc_settings1.Location = new Point(55, 60);
            this.uc_settings1.Size = new System.Drawing.Size(uc_settings1.Width+180, uc_settings1.Height);
*/
            logoPicture.Visible = false;
            sidebarHide.Visible = false;
            sidebarShow.Visible = true;
            leftPanel.Visible = false;
            leftPanel.Width = 55;
            guna2Transition1.ShowSync(leftPanel);
        }


        // change theme.
        private void btn_settings_Click(object sender, EventArgs e)
        {
            /* colorThemePanel.Hide();
             uc_settings1.Show();*/
           /* uc_Admin_AddEmployee1.Show();
            uc_Admin_AddEmployee1.BringToFront();*/
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // check condition for maximize and normal both mode
        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;

            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }











        // focus on coursore move.
        private void btn_exit_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_exit.Size = new System.Drawing.Size(35, 35);
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
        }

        private void btn_minimize_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_minimize.Size = new System.Drawing.Size(35, 35);
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
        }

        private void btn_maximize_MouseLeave(object sender, EventArgs e)
        {
            this.btn_maximize.Size = new System.Drawing.Size(30, 30);
        }

        private void btn_maximize_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_maximize.Size = new System.Drawing.Size(35, 35);
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {

        }



        // change the themes :)
        public void ChangeDashboardTheme(string leftPanelColor, string bodyPanelColor, string topPanelColor, string logoPanelColor)
        {
            leftPanel.BackColor = ColorTranslator.FromHtml(leftPanelColor);
            this.BackColor = ColorTranslator.FromHtml(bodyPanelColor);
            topPanel.BackColor = ColorTranslator.FromHtml(topPanelColor);
            logoPanel.BackColor = ColorTranslator.FromHtml(logoPanelColor);

        }


        private void btn_Theme_Click(object sender, EventArgs e)
        {
            uc_Admin_AddEmployee1.Hide();
            uc_Admin_EmployeeDetails1.Hide();
            uc_Admin_RemoveEmployee1.Hide();
            uc_Admin_Salary1.Hide();


            colorThemePanel.Show();
            colorThemePanel.BringToFront();
         }

        private void btn_theme_light_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#CBD0F6", "#D7F1FE", "#E5D4F8", "#E5D4F8");
        }

        private void DefaultTheme_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#212F3D", "#34495E", "#2C3D4F", "#2C3D4F");
        }

        private void btn_theme_purple_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#2C3D4F", "#3B1E78", "#482382", "#482382");
        }

        private void btn_theme_green_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#28B463", "#1ABC9C", "#0E6251", "#0E6251");
        }

        private void btn_theme_red_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#C0392B", "#CD6155", "#943126", "#943126");
        }

        private void btn_theme_gray_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#212F3D", "#34495E", "#AEB6BF", "#AEB6BF");
        }

        private void btn_theme_blue_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#1B4F72", "#2471A3", "#7FB3D5", "#7FB3D5");
        }

        private void btn_theme_yellow_Click(object sender, EventArgs e)
        {
            ChangeDashboardTheme("#D35400", "#F8C471", "#F5B041", "#F5B041");
        }



        // add employee
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            uc_Admin_AddEmployee1.Visible = true;
            uc_Admin_AddEmployee1.BringToFront();
        }

        private void btn_RemoveEmployee_Click(object sender, EventArgs e)
        {
            uc_Admin_RemoveEmployee1.Visible = true;
            uc_Admin_RemoveEmployee1.BringToFront();
        }

        private void btn_EmployeeDetails_Click(object sender, EventArgs e)
        {
            uc_Admin_EmployeeDetails1.Visible = true;
            uc_Admin_EmployeeDetails1.BringToFront();
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            uc_Admin_Salary1.Visible = true;
            uc_Admin_Salary1.BringToFront();
        }


        // change panel focus
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            uc_Admin_Dashboard1.Visible = true;
            uc_Admin_Dashboard1.BringToFront();

            // refresh all data of dashboard
            Uc_Admin_Dashboard dashboard = new Uc_Admin_Dashboard();
            dashboard.LoadAdminDashboardData();
        }
    }
}
 