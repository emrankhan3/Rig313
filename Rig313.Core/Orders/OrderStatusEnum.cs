using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Orders
{
	public enum OrderStatusEnum
	{
        Pending = 1,
        Processing = 2,
        Shipped = 3,
        Delivered = 4,
        Returned = 5,
        Cancelled = 6
    }
}
