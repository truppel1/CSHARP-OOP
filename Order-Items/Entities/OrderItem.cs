using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; } = 0;
        public double Price { get; set; } = 0;
        Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = Product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", " + "U$" +
                   Product.Price.ToString("F2") +
                ", Quantity: " + Quantity +
                ", Subtotal: U$" + SubTotal().ToString("F2");
        }
    }
}
