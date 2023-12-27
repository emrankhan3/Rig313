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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(u => u.Name).IsRequired();
            modelBuilder.Entity<Category>().Property(u => u.DisplayOrder).IsRequired();
            modelBuilder.Entity<Category>().HasKey(u => u.Id);
            modelBuilder.Entity<Category>().Property(u => u.Name).HasMaxLength(50);
            
            
            //product
            modelBuilder.Entity<Product>().Property(u => u.Price).IsRequired();

            modelBuilder.Entity<Product>().HasKey(u => u.Id);
            //relationship between product and category many to one
            //many product in 1 category
            modelBuilder.Entity<Product>().HasOne(u => u.Category)
                .WithMany(u => u.Products)
                .HasForeignKey(u => u.CategoryId);
            
            //inventory
            modelBuilder.Entity<Inventory>().HasKey(u => u.Id);
            
            //relationship between inventory and product
            modelBuilder.Entity<Inventory>().HasOne(b => b.Product)
                .WithOne(b => b.Inventories)
                .HasForeignKey<Inventory>(u=>u.ProductId);
            
            
            //user 
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired();
            
            //user - userpermisson relation 1-1
            modelBuilder.Entity<UserPermission>().HasOne(b => b.User)
                .WithOne(b => b.UserPermission)
                .HasForeignKey<UserPermission>(u => u.UserId);
            
            //USER and customer one to one setup
            modelBuilder.Entity<Customer>().HasOne(b => b.User)
                .WithOne(b => b.Customer)
                .HasForeignKey<Customer>(u => u.UserId);
            
            
            //cart item
            modelBuilder.Entity<CartItem>().HasKey(u => u.CartId);
            //relationsheep between cartitem and product
            modelBuilder.Entity<CartItem>().HasOne(b => b.Product)
                .WithOne(b => b.CartItem)
                .HasForeignKey<CartItem>(b => b.ProductId);
            
            //cart
            modelBuilder.Entity<Cart>().HasKey(u => u.Id);
            //cart item and cart one to many
            modelBuilder.Entity<CartItem>().HasOne(u => u.Carts)
                .WithMany(u => u.CartItems)
                .HasForeignKey(u => u.CartId);
            //CART CUSTOMER ONE TO ONE 
            modelBuilder.Entity<Cart>().HasOne(b => b.Customer)
                .WithOne(b => b.Cart)
                .HasForeignKey<Cart>(b => b.CustomerId);
            
            //order
            modelBuilder.Entity<Order>().HasKey(u => u.Id);
            //one to one order to customer
            modelBuilder.Entity<Order>().HasOne(b => b.Customer)
                .WithOne(b => b.Order)
                .HasForeignKey<Order>(b => b.CustomerId);
            
            //ORDERITEM order to order item many to one
            modelBuilder.Entity<OrderItem>().HasKey(u => u.Id);
            modelBuilder.Entity<OrderItem>().HasOne(u => u.Order)
                .WithMany(u => u.OrderItems)
                .HasForeignKey(u => u.OrderId);
            //order item to product one to one relation
            modelBuilder.Entity<OrderItem>().HasOne(u => u.Product)
                .WithOne(u => u.OrderItem)
                .HasForeignKey<OrderItem>(u => u.ProductId);
            
            









        }
    }
    

}
