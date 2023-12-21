using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Products
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string  ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int Discount { get; set; }


    }
}
