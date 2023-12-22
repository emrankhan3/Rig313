using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Core.Users
{
    public class UserPermission : BaseEntity
    {
        public int UserId { get; set; }
        public bool Customer { get; set; }
        public bool SuperAdmin { get; set; }
        public bool CategoryManager{ get; set; }
        public bool ProductManager { get; set; }
        public bool InventoryManager { get; set; }
        public bool CustomerManager { get; set; }
    }
}
