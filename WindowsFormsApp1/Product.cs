using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductUnit { get; set; }

        public Product(int id, string name, decimal price, string description, int quantity, string unit)
        {
            ProductID = id;
            ProductName = name;
            ProductPrice = price;
            ProductDescription = description;
            ProductQuantity = quantity;
            ProductUnit = unit;
        }

    }
}
