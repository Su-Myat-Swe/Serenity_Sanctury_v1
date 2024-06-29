namespace Serenity_Sanctury_v1.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public Address? Address { get; set; } // Nullable Address property
        public string Role { get; set; }
    }
}
