namespace OrderManagement.Events
{
    public class OrderPlacedEvent
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemEvent> Items { get; set; } = new List<OrderItemEvent>();
    }

    public class OrderItemEvent
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}