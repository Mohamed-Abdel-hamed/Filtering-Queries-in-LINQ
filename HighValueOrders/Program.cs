namespace HighValueOrders
{
    internal class Program
    {
        public static void Main()
        {
            List<Order> orders = CreateOrderList();
            decimal minValue = 1000;

            var highValueOrders = GetHighValueOrders(orders, minValue);

            foreach (var order in highValueOrders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Total Amount: {order.TotalAmount}, Status: {order.Status}");
            }
        }

        public static List<Order> CreateOrderList()
        {
            return new List<Order>
        {
            new Order(1, 500, OrderStatus.Completed),
            new Order(2, 1500, OrderStatus.Completed),
            new Order(3, 750, OrderStatus.Pending),
            new Order(4, 1200, OrderStatus.Completed),
            new Order(5, 300, OrderStatus.Cancelled)
        };
        }

        public static List<Order> GetHighValueOrders(List<Order> orders, decimal minValue)
        {
            return orders
                .Where(order => order.TotalAmount > minValue
                && order.Status == OrderStatus.Completed
                ).ToList();

        }
    }
}
