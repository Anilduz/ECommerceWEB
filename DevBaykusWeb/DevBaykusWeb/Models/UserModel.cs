using System;
namespace DevBaykusWeb.Models
{
	public class UserModel
	{
		//asd
        public int Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Address { get; set; }
        public string? Address_2 { get; set; }
        public string? CreditCardInfos { get; set; }
		public DateTime LastLogoutDate { get; set; }
		public string? IsActive { get; set; }
		
	}
}

