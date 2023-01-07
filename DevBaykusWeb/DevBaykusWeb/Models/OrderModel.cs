using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DevBaykusWeb.Models
{
	public class OrderModel
	{
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Amount{ get; set; }
        public string? Currency{ get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Status { get; set; }
        //
        //
        //
        // sipariş içerisindeki ürünler kullanıcıya daha sonra nasıl gösterilecek? bu tabloda nasıl tutulacak? araştırılacak.!!!!!!
	}
}

