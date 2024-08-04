using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Serenity_Sanctury_v1.Data.Enum;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace Serenity_Sanctury_v1.Models.DataLayer
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        //public DbSet<User> Users { get; set; } = null!;

        public DbSet<OrderTracking> OrderTrackings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Seed data for Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    ProductName = "Honeyed Harmony",
                    Category = Category.Candles,
                    Description = "A soothing candle for relaxation.",
                    Scent = "Honey and Vanilla",
                    BurnTime = "48 hours",
                    Size = "8 oz",
                    Container = "Black color Glass Jar",
                    Price = 10.00m,
                    Quantity = 100,
                    ImageUrl = "~/Image/product2.jpeg"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Serenity Blossom",
                    Category = Category.Candles,
                    Description = "A tranquil candle with a refreshing floral scent, perfect for creating a peaceful atmosphere.",
                    Scent = "Cherry Blossom",
                    BurnTime = "40 hours",
                    Size = "10 oz",
                    Container = "Transparent Glass Jar",
                    Price = 12.99m,
                    Quantity = 150,
                    ImageUrl = "~/Image/product3.jpeg"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Soothing Sandalwood Essence",
                    Category = Category.EssentialOil,
                    Description = "Premium sandalwood essential oil for a calming and aromatic experience.",
                    Scent = "Sandalwood",
                    BurnTime = null,  // Essential oils don't have burn time
                    Size = "30 ml",
                    Container = "Black Glass Bottle",
                    Price = 9.99m,  // Discounted price
                    Quantity = 120,
                    ImageUrl = "~/Image/product4.jpeg"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Invigorating Tea Tree",
                    Category = Category.EssentialOil,
                    Description = "Pure tea tree essential oil known for its refreshing and invigorating properties.",
                    Scent = "Tea Tree",
                    BurnTime = null,  // Essential oils don't have burn time
                    Size = "30 ml",
                    Container = "Black Glass Bottle",
                    Price = 9.99m,  // Discounted price
                    Quantity = 150,
                    ImageUrl = "~/Image/product4.jpeg"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Tranquil Twilight",
                    Category = Category.Candles,
                    Description = "A soothing candle that brings a sense of calm and tranquility, perfect for your twilight hours.",
                    Scent = "Lavender and Chamomile",
                    BurnTime = "50 hours",
                    Size = "12 oz",
                    Container = "Black Glass Jar",
                    Price = 10.99m,
                    Quantity = 100,
                    ImageUrl = "~/Image/product2.jpeg"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Lavender Dreams",
                    Category = Category.Candles,
                    Description = "A calming candle infused with the soothing scent of lavender, perfect for creating a relaxing ambiance.",
                    Scent = "Lavender",
                    BurnTime = "40 hours",
                    Size = "8 oz",
                    Container = "Transparent Glass Jar",
                    Price = 12.99m,
                    Quantity = 75,
                    ImageUrl = "~/Image/product3.jpeg"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Rose Petal Oasis",
                    Category = Category.Candles,
                    Description = "A luxurious candle with the delicate and romantic scent of rose petals, ideal for creating a serene atmosphere.",
                    Scent = "Rose Petals",
                    BurnTime = "45 hours",
                    Size = "8 oz",
                    Container = "Transparent Glass Jar",
                    Price = 12.99m,
                    Quantity = 80,
                    ImageUrl = "~/Image/product3.jpeg"
                },
                new Product()
                {
                    ProductID = 8,
                    ProductName = "Citrus Sunrise",
                    Category = Category.Candles,
                    Description = "A vibrant candle with an invigorating citrus scent that brightens up any room and lifts your spirits.",
                    Scent = "Citrus Blend",
                    BurnTime = "40 hours",
                    Size = "8 oz",
                    Container = "Black Glass Jar",
                    Price = 10.99m,
                    Quantity = 90,
                    ImageUrl = "~/Image/product2.jpeg"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Lemongrass Harmony",
                    Category = Category.EssentialOil,
                    Description = "A refreshing essential oil with a zesty lemongrass scent, perfect for revitalizing your senses and uplifting your mood.",
                    Scent = "Lemongrass",
                    BurnTime = null,  // Essential oil doesn't have burn time
                    Size = "30 ml",
                    Container = "Black Glass Bottle",
                    Price = 12.99m,
                    Quantity = 100,
                    ImageUrl = "~/Image/product4.jpeg"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Berry Bliss",
                    Category = Category.Candles,
                    Description = "A delightful candle that combines the sweet and tangy aromas of mixed berries, creating a blissful and uplifting atmosphere.",
                    Scent = "Berry Blend",
                    BurnTime = "40 hours",
                    Size = "8 oz",
                    Container = "Black Glass Jar",
                    Price = 12.99m,
                    Quantity = 120,
                    ImageUrl = "~/Image/product2.jpeg"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Vanilla Velvet",
                    Category = Category.Candles,
                    Description = "A luxurious candle that envelops you in the rich and creamy aroma of vanilla, creating a cozy and relaxing ambiance.",
                    Scent = "Vanilla",
                    BurnTime = "45 hours",
                    Size = "8 oz",
                    Container = "Transparent Glass Jar",
                    Price = 10.99m,
                    Quantity = 150,
                    ImageUrl = "~/Image/product3.jpeg"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Classic Design Aroma Diffuser",
                    Category = Category.AromaDiffuser,
                    Description = "Enhance your home with the Classic Design Aroma Diffuser.This stylish diffuser adds a calming touch to any room with soothing essential oil scents and a gentle mist.Ideal for creating a relaxing atmosphere and  a touch of elegance.",
                    Scent = null,  // Diffusers might not have a scent themselves
                    BurnTime = null,  // Diffusers don't burn, so this can be marked as N/A
                    Size = null,
                    Container = "Classic Ceramic",
                    Price = 79.99m,
                    DiscountedPrice = 49.99m,
                    Quantity = 50,
                    ImageUrl = "~/Image/product5.jpeg"
                }
         );

            //// Seed data for User
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = "1",
            //        LastName = "Tomer",
            //        FirstName = "Cus",
            //        FullName = "Cus Tomer",
            //        PhoneNo = null,
            //        Email = "customer@example.com",
            //        Birthday = new DateTime(1998, 12, 2),
            //        Gender = "Male",
            //        Role = "Customer",

            //    }

            //);

            //// Seed data for User
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = "3",
            //        LastName = "Istrator",
            //        FirstName = "Admin",
            //        FullName = "Admin Istrator",
            //        PhoneNo = null,
            //        Email = "administrator@example.com",
            //        Birthday = null,
            //        Gender = "Male",
            //        Address = "221 Ring Road, Callaghan, NSW, 2308, Australia"
            //    }
            //);

            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = "3",
            //        LastName = "Oyee",
            //        FirstName = "Empl",
            //        FullName = "Empl Oyee",
            //        PhoneNo= null,
            //        Email = "employee@example.com",
            //        Birthday = null,
            //        Gender = "Male",
            //        Role = "Employee",

            //    }
            //);

            // Seed data for Order
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderID = 1,
                    CustomerID = "1",
                    Address = "221 Ring Road, Callaghan, NSW, 2308, Australia",
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

        }
    }
}
