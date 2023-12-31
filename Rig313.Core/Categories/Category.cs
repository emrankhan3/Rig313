﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Core.Products;

namespace Rig313.Core.Categories
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int DisplayOrder { get; set; }
        public string? ImageUrl { get; set; }
        public List<Product> Products { get; set; }

    }
}
