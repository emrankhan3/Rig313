using Microsoft.EntityFrameworkCore;
using Rig313.Core.Carting;
using Rig313.Core.Categories;
using Rig313.Core.Customers;
using Rig313.Core.Inventories;
using Rig313.Core.Orders;
using Rig313.Core.Products;
using Rig313.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rig313.Data.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Inventory> Inventory{ get; set; }
        public DbSet<Order> Order  { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<UserPermission> UserPermissions{ get; set; }
        public DbSet<Customer> Customer  { get; set; }
        public DbSet<Cart> Cart{ get; set; }
        public DbSet<CartItem> CartItem{ get; set; }

    }
}
