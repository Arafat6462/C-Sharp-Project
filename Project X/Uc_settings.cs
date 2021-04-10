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
    public partial class Uc_settings : UserControl
    {
        public Uc_settings()
        {
            InitializeComponent();
        }

        private void btn_theme_light_Click(object sender, EventArgs e)
        {
            AdminControllerDashboard adminControllerDashboard = new AdminControllerDashboard();
            adminControllerDashboard.ChangeDashboardTheme("#C1D8F9", "#D7F1FE", "#C1D8F9");
        }
    }
}
