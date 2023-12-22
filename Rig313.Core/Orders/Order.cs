using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Orders
{
    public class Order:BaseEntity
    {
        public int CustomerId { get; set; }
        public String  ShipmentAddress { get; set; }
        public int OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public int PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }
        public float ShipmentCharge { get; set; }
        public float PaidAmount { get; set; }
        public DateTime PlacingDateTime { get; set; }
        public DateTime? ProcessingDateTime { get; set; }
        public DateTime? ShippingDateTime { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public DateTime? CancelDateTime { get; set; }
        public DateTime? ReturnDateTime { get; set; }
        public DateTime? PaymentDateTime { get; set; }
    }
}
