using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Core.Customers;

namespace Rig313.Core.Users
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int UserRole { get; set; }
        public UserPermission? UserPermission { get; private set; }

        public Customer Customer { get; set; }
    }
}
