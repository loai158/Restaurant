using Microsoft.AspNetCore.Identity;

namespace Restaurant.Models
{
    public class ApplicationUser:IdentityUser
    {
        public List<Order>? Orders{ get; set; }
    }
}
