using Enum1.Entities.Enums;

namespace Enum1.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        override public string ToString()
        {
            return $"Order Id: {Id}, Moment: {Moment}, Status: {Status}";
        }
    }
}
