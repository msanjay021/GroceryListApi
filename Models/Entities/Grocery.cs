using GroceryList.Services;

namespace GroceryList.Models.Entities
{
	public class Grocery : IGrocery
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public decimal Quantity { get; set; }
		public DateTime PurchaseDate { get; set; } = DateTime.Now;
	}
}
