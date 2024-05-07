using EventBookingApp.Enums;

namespace EventBookingApp.Model
{
    public class User : BaseEntity
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string PhoneNumber { get; set; }
        private bool IsVerified { get; set; }
        private DateTime DOB { get; set; }
        private Role Role { get; set; }
    }
}