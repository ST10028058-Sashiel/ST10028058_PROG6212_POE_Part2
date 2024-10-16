using Microsoft.AspNetCore.Identity;

namespace ST10028058_PROG6212_POE_Part2.Models
{

	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}
}