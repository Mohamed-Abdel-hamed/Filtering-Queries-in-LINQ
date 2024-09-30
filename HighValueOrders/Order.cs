using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighValueOrders
{
    internal class Order
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int id, decimal totalAmount, OrderStatus status)
        {
            Id = id;
            TotalAmount = totalAmount;
            Status = status;
        }
    }

    public enum OrderStatus
    {
        Pending,
        Completed,
        Cancelled
    }

}
