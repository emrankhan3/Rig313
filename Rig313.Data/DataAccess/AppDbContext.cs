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



            modelBuilder.Entity<Category>().HasData(
                new { Id = 1, Name = "Laptop", Description ="Laptop Description", DisplayOrder =1, ImageUrl="SampleImageUrl"},
                new { Id = 2, Name = "Desktop", Description = "Desktop Description", DisplayOrder = 2, ImageUrl = "SampleImageUrl2" },
                new { Id = 3, Name = "Accessories", Description = "Accessories", DisplayOrder = 3, ImageUrl = "SampleImageUrl3" }
            );
            modelBuilder.Entity<Product>().HasData(
                new { Id = 1, Name = "Laptop 1", Description = "Laptop1 Description", Price=60000.0, CategoryId=1, Discount=0.0, ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product01.png?alt=media&token=f6ab9d5e-2916-4bd9-9905-9ec8e9c37cf3" },
                new { Id = 2, Name = "Laptop 2", Description = "Laptop2 Description", Price=63000.0, CategoryId=1, Discount=0.0, ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product03.png?alt=media&token=0d819674-53bf-41d0-8068-9b840799475e" },
                new { Id = 3, Name = "Desktop 1", Description = "Desktop1 Description", Price=48000.0, CategoryId=2, Discount=0.05, ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product06.png?alt=media&token=94a3f820-5f16-4aa3-91ba-2c35ae221f69" },
                new { Id = 4, Name = "Desktop 2", Description = "Desktop2 Description", Price=50000.0, CategoryId=2, Discount=0.0, ImageUrl = "https://firebasestorage.googleapis.com/v0/b/rig313.appspot.com/o/product08.png?alt=media&token=0b023b8b-533a-4b65-8f24-9183803a9e42" }
            );

            modelBuilder.Entity<Inventory>().HasData(
                new { Id = 1, ProductId = 1, StockAvailable = 30, OnPending=0, OnShipped = 0, Delivered = 0},
                new { Id = 2, ProductId = 2, StockAvailable = 20, OnPending=0, OnShipped = 0, Delivered = 0},
                new { Id = 3, ProductId = 3, StockAvailable = 45, OnPending=0, OnShipped = 0, Delivered = 0},
                new { Id = 4, ProductId = 4, StockAvailable = 0, OnPending=0, OnShipped = 0, Delivered = 0}
            );

            modelBuilder.Entity<User>().HasData(
                new {Id = 1, Username="admin", Password = "amdin", Phone="+880123456789", Email = "admin@rig313.com", UserRole = 1},
                new {Id = 89, Username="customer", Password = "customer", Phone="+880123456780", Email = "customer@rig313.com", UserRole = 2}
            );
            
            modelBuilder.Entity<UserPermission>().HasData(
                new {Id = 1, UserId=1, Customer = false, SuperAdmin=true, CategoryManager = true, ProductManager = true, InventoryManager = true, CustomerManager = true},
                new {Id = 89, UserId=89, Customer = true, SuperAdmin=false, CategoryManager = false, ProductManager = false, InventoryManager = false, CustomerManager = false}
            );

            
            modelBuilder.Entity<Customer>().HasData(
                new { Id = 89, Name = "Customer 1", Address = "Customer Address", UserId = 89}
            );



        }
    }
    

}
