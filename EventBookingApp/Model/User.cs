﻿using EventBookingApp.Enums;

namespace EventBookingApp.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVerified { get; set; }
        public DateTime DOB { get; set; }
        public Role Role { get; set; }
    }
}