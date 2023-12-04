namespace AdressBookApp.Server.Models
{
    public class Result
    {
        public string Gender { get; set; } = null!;
        public Name Name { get; set; } = null!;
        public Location Location { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Login Login { get; set; } = null!;
        public Dob Dob { get; set; } = null!;
        public Registered Registered { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Cell { get; set; } = null!;
        public Id Id { get; set; } = null!;
        public Picture Picture { get; set; } = null!;
        public string Nat { get; set; } = null!;
    }
}
