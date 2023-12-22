using Rig313.Core.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Carting
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public IList<CartItem>? CartItems { get; private set; }
        public Customer? Customer { get; private set; }
    }
}
