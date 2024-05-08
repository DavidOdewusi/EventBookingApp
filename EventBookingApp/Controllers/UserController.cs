using EventBookingApp.Data;
using EventBookingApp.Enums;
using EventBookingApp.Model;
using EventBookingApp.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventBookingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EventBookingAPIDbContext dbContext;

        public UserController(EventBookingAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(dbContext.Users.ToList());
        }

        [HttpPost]
        public IActionResult AddUsers(SignUpRequest signUpRequest)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = signUpRequest.FirstName,
                LastName = signUpRequest.LastName,
                Email = signUpRequest.Email,
                Password = signUpRequest.Password,
                PhoneNumber = signUpRequest.PhoneNumber,
                DOB = signUpRequest.DOB,
                Role = Role.ROLE_USER
            };


            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return Ok(dbContext.Users);
        }
            
         
    }
}
