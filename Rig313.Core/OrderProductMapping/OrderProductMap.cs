using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.OrderProductMapping
{
    internal class OrderProductMap:BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Unit { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }


    }
}
