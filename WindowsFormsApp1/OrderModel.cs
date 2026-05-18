using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OrderItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public decimal Subtotal => ProductPrice * ProductQuantity;
    }

    public class Order
    {
        public string OrderName { get; set; }
        public string OrderDescription { get; set; }
        public string OrderDate { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public decimal TotalAmount { get; set; }
    }
}
