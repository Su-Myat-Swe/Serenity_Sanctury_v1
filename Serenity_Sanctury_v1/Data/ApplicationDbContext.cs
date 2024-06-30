using Microsoft.EntityFrameworkCore;
using Serenity_Sanctury_v1.Data.Enum;
using Serenity_Sanctury_v1.Models;
using System.Net.NetworkInformation;

namespace Serenity_Sanctury_v1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<OrderTracking> OrderTrackings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "Aromatherapy Candle",
                    Category = Category.Candles,
                    Description = "A soothing candle for relaxation.",
                    Color = "Black",
                    Price = 10.00m,
                    Quantity = 100,
                    ImageUrl = "candle.jpg"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Lavender Essential Oil",
                    Category = Category.EssentialOil,
                    Description = "Pure lavender essential oil.",
                    Color = "Clear",
                    Price = 15.00m,
                    Quantity = 200,
                    ImageUrl = "lavender_oil.jpg"
                }
            );

            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    LastName = "Tomer",
                    FirstName = "Cus",
                    FullName = "Cus Tomer",
                    PhoneNo = null,
                    Email = "customer@example.com",
                    Password = "Password1",
                    Birthday = new DateOnly(1998, 12, 2),
                    Gender = "Male",
                    Role = "Customer"
                }
            );

            // Seed data for Admin
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    ID = 1,
                    LastName = "Istrator",
                    FirstName = "Admin",
                    FullName = "Admin Istrator",
                    PhoneNo = null,
                    Email = "administrator@example.com",
                    Password = "Pa$$w0rd",
                    Address = null
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 2,
                    LastName = "Oyee",
                    FirstName = "Empl",
                    FullName = "Empl Oyee",
                    PhoneNo= null,
                    Email = "employee@example.com",
                    Password = "Passw0rd",
                    Birthday = null,
                    Gender = "Male",
                    Role = "Employee",
                    Address = null
                }
            );

            // Seed data for Address
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    ID = 1,
                    Streetline = "221 Ring Road",
                    City = "Callaghan",
                    State = "NSW",
                    PostalCode = "2308",
                    Country = "Australia"
                }
            );

            // Seed data for Order
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderID = 1,
                    CustomerID = 1,
                    AddressID = 1,
                    OrderDate = DateTime.Now,
                    TotalPrice = 35.98m,
                    OrderStatus = OrderStatus.Pending
                }
            );

            // Seed data for OrderTracking
            modelBuilder.Entity<OrderTracking>().HasData(
                new OrderTracking
                {
                    TrackingID = 1,
                    OrderID = 1,
                    OrderEmail = "customer@example.com",
                    PostalCode = "2308",
                    StatusUpdate = "Order placed",
                    UpdateTime = DateTime.UtcNow
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
