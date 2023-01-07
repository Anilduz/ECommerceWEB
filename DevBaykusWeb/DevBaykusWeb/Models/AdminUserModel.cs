using System;
namespace DevBaykusWeb.Models
{
	public class AdminUserModel
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string? IsActive { get; set; }
    }
}


