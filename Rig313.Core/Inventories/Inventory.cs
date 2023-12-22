using Rig313.Core.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Inventories
{
    public class Inventory : BaseEntity
    {
        public int ProductId { get; set; }
        public int StockAvailable { get; set; }
        public int OnPending { get; set; }
        public int OnShipped { get; set; }
        public int Delivered { get; set; }

        public Product? Product { get; private set; }
    }
}
