using EventBookingApp.Enums;

namespace EventBookingApp.Model.Requests
{
    public class SignUpRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
    }
}
