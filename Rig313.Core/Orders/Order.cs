using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Orders
{
    internal class Order:BaseEntity
    {
        public int CustomerId { get; set; }
        public String  ShipmentAddress { get; set; }
        public int OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public int PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }
        public float ShipmentCharge { get; set; }
    }
}
