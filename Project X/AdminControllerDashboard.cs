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
            uc_settings1.Location = new Point(243, 60);
            this.uc_settings1.Size = new System.Drawing.Size(uc_settings1.Width - 180, uc_settings1.Height);

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
            uc_settings1.Location = new Point(55, 60);
            this.uc_settings1.Size = new System.Drawing.Size(uc_settings1.Width+180, uc_settings1.Height);

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










        // change the themes :)
        public void ChangeDashboardTheme(string leftPanelColor, string bodyPanelColor, string topPanelColor)
        {
            leftPanel.BackColor = ColorTranslator.FromHtml(leftPanelColor);
            this.BackColor = ColorTranslator.FromHtml(bodyPanelColor);

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
    }
}
