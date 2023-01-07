using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DevBaykusWeb.Models
{
	public class ProductModel
	{
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public double Price { get; set; }
        public string? Currency { get; set; }
        public int Stock { get; set; }
        public string? Photo { get; set; }


	}
}

