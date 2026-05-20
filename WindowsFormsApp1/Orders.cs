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
        private BindingList<Product> _availableProducts;
        private BindingList<OrderItem> _currentOrderItems = new BindingList<OrderItem>();
        private string _csvpath = "H:/Programming/WindowsFormsApp3/shop-product-catalog - shop-product-catalog.csv";
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

            dgvCurrent.ReadOnly = true;
            dgvCurrent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrent.MultiSelect = false;

            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvCurrent.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvCurrent.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            dgvCurrent.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCurrent.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCurrent.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            dgvCurrent.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            dgvCurrent.DataSource = _currentOrderItems;
            dgvCurrent.AllowDrop = true;
        }

        private void Orders_UC_Load(object sender, EventArgs e)
        {
            try
            {
                var products = InventoryService.LoadFromCSV(_csvpath);
                _availableProducts = new BindingList<Product>(products);
                dgvAvailable.DataSource = _availableProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inventory couldn't be loaded" + ex.Message);
            }
        }

        private void dgvAvailable_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                var product = (Product)dgvAvailable.SelectedRows[0].DataBoundItem;
                dgvAvailable.DoDragDrop(product, DragDropEffects.Copy);
            }
        }

        private void dgvAvailable_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Product)))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void dgvAvailable_DragDrop(object sender, DragEventArgs e)
        {
            Product droppedProduct = (Product)e.Data.GetData(typeof(Product));
            AddProductToOrder(droppedProduct);
        }

        private void AddProductToOrder(Product product)
        {
            var existingItem = _currentOrderItems.FirstOrDefault(i => i.ProductID == product.ProductID);

            if (existingItem != null)
            {
                existingItem.ProductQuantity++;
            } else
            {
                _currentOrderItems.Add(new OrderItem
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                    ProductQuantity = 1
                });
            }
        }
    }
}
