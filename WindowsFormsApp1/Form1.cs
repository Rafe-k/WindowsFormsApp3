using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApp1
{
   public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }

        

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            showScreen(new Inventory_UC());
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void showScreen(UserControl newScreen)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Dispose();
            }

            panel1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            panel1.Controls.Add(newScreen);
        }

        private void buttonInventory_Click_1(object sender, EventArgs e)
        {
            showScreen(new Inventory_UC());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showScreen(new Orders());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

   

   


}
