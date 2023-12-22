using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Customers
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
<<<<<<< Updated upstream
        public string Phone { get; set; }
        public string?  Email { get; set; }
=======
        public int UserId { get; set; }

        public User? User { get; private set; }
>>>>>>> Stashed changes
    }
}
