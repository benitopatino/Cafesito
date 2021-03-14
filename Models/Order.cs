using System;
namespace Cafesito.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public byte OrderStatusId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}