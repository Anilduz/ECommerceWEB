using System;
using System.Net;
using System.Reflection;

namespace DevBaykusWeb.Models
{
	public class UserModel
	{
        public int Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Address_2 { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string? IsActive { get; set; }

    }
}

