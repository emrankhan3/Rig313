﻿using Rig313.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Core.Carting;
using Rig313.Core.Orders;

namespace Rig313.Core.Customers
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }

        public User? User { get; private set; }
        public Cart Cart { get; set; }
        public Order Order { get; set; }
    }
}
