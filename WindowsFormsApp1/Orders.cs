using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Orders : UserControl
    {
        private BindingList<Product> availableProducts;
        private BindingList<OrderItem> currentOrderItems = new BindingList<OrderItem>();
        public Orders()
        {
            InitializeComponent();
            SetupOrderSystem();
        }

        private void SetupOrderSystem()
        {
            dgvAvailable.ReadOnly = true;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.MultiSelect = false;


        }
    }
}
