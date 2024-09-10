namespace Contractor_Claims.Models
{
    public class Account
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }  // Consider encrypting this in real projects
        public required string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
