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
            leftPanel.BackColor = ColorTranslator.FromHtml("#728F9D");
            this.BackColor = ColorTranslator.FromHtml("#E3E3E3");
        }
    }
}
