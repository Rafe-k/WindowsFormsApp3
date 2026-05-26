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
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Inventory_UC : UserControl
    {
        public Inventory_UC()
        {
            InitializeComponent();
        }

        private BindingList<Product> inventory_list = new BindingList<Product>();
        private BindingSource binding_variable_name = new BindingSource();


        string csv_path = "H:/Programming/WindowsFormsApp3/shop-product-catalog - shop-product-catalog.csv";

        private void Inventory_UC_load(object sender, EventArgs e)
        {

        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxID.Text, out int idToUpdate))
            {
                MessageBox.Show("Select a product from the grid to update");
                return;
            }

            var productToUpdate = inventory_list.FirstOrDefault(p => p.ProductID == idToUpdate);

            if (productToUpdate != null)
            {
                if (ValidateInputs())
                {

                    productToUpdate.ProductName = textBoxName.Text;
                    productToUpdate.ProductPrice = decimal.Parse(textBoxPrice.Text);
                    productToUpdate.ProductDescription = textBoxDescription.Text;
                    productToUpdate.ProductQuantity = int.Parse(textBoxQuantity.Text);
                    productToUpdate.ProductUnit = textBoxUnit.Text;

                    binding_variable_name.ResetBindings(false);
                    dataGridView1.Refresh();

                    ClearFields();
                    MessageBox.Show("Product updated successfully");
                }
            } else
            {
                MessageBox.Show("Product ID not found in inventory");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            DialogResult result = MessageBox.Show($"Are you sure you would like to add {textBoxDelete.Text}?", "Confirm addition", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                int newId = inventory_list.Count + 1000;
                string newName = textBoxName.Text;
                decimal newPrice = decimal.Parse(textBoxPrice.Text);
                string newDescription = textBoxDescription.Text;
                int newQuantity = int.Parse(textBoxQuantity.Text);
                string newUnit = textBoxUnit.Text;

                Product newProduct = new Product(newId, newName, newPrice, newDescription, newQuantity, newUnit);

                inventory_list.Add(newProduct);

                binding_variable_name.ResetBindings(false);

                ClearFields();

                textBoxDelete.Clear();
                MessageBox.Show("The product was successfully added");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Enter the ID of the product you wish to delete");
                return;
            }

            Product productToDelete = inventory_list.FirstOrDefault(p => p.ProductID.ToString() == searchTerm || p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {
                DialogResult result = MessageBox.Show($"Are you sure you would like to delete {productToDelete.ProductName}?", "Confirm delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory_list.Remove(productToDelete);

                    textBoxDelete.Clear();
                    MessageBox.Show("The product was successfully deleted");
                }
            } else {
                MessageBox.Show("No product was found that matched that name or ID");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string path = csv_path;

            var temp_list = InventoryService.LoadFromCSV(path);
            inventory_list.Clear();
            foreach (var item in temp_list)
            {
                inventory_list.Add(item);
            }
            dataGridView1.DataSource = inventory_list;
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product name contains invalid characters");
                return false;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Enter a valid positive price");
                return false;
            }

            if (!int.TryParse(textBoxQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Invalid quantity");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxDescription.Clear();
            textBoxQuantity.Clear();
            textBoxUnit.Clear();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {

        }
    }
}
