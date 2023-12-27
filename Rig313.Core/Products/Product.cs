using Rig313.Core.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Core.Carting;
using Rig313.Core.Inventories;
using Rig313.Core.Orders;

namespace Rig313.Core.Products
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string?  ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public double Discount { get; set; }

        public Category? Category { get; private set; }
        
        public Inventory Inventories { get; set; }

        public CartItem CartItem { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}
