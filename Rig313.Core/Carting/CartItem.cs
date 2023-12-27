using Rig313.Core.Orders;
using Rig313.Core.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Carting
{
    public class CartItem : BaseEntity
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; private set; }
        public Cart Carts { get; set; }
        
    }
}
