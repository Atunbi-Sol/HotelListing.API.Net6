using System.ComponentModel.DataAnnotations;

namespace HotellistingAPI.Models.Users
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
      
    }

}
