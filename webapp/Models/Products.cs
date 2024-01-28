using System;
namespace webapp.Models
{
	public class Products
	{
		public int ProductID { get; set; }

		public required string ProductName { get; set; }

		public int Quantity { get; set; }
	}
}

