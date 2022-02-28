using System;
using System.Collections.Generic;
using System.Text;
using Store.Entities.Enums;
using System.Globalization;

namespace Store.Entities
{
    internal class Order
    {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Clientt { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Clientt = client;
        }

        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
        
       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine("Client: " + Clientt);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: U$" + Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
