namespace GroceryList.Services
{
	public interface IGrocery
	{
		int Id { get; set; }
		string Name { get; set; }
		int Price { get; set; }
		DateTime PurchaseDate { get; set; }
		decimal Quantity { get; set; }
	}
}