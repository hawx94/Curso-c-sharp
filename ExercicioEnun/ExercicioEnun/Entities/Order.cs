using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnun.Entities.Enum
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, Client client, OrderStatus orderStatus)
        {
            Moment = moment;
            Client = client;
            OrderStatus = orderStatus;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

    }
}
