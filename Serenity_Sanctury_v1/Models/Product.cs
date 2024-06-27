using System;

public class Class1
{
	public Class1()
	{
	}
}
namespace Serenity_Sanctury_v1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public char Category { get; set; }
        public string Description { get; set; }
        public int Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}