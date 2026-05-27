using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home_UserControl : UserControl
    {
        public Home_UserControl()
        {
            InitializeComponent();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {

        }

        //private static void showScreen(UserControl newScreen)
        //{
        //    foreach (Control ctrl in Home_UserControl.Controls)
        //    {
        //        ctrl.Dispose();
        //    }

        //    Home_UserControl.Controls.Clear();
        //    newScreen.Dock = DockStyle.Fill;
        //    Home_UserControl.Controls.Add(newScreen);

        //}
    }
}
