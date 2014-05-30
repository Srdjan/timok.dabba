namespace Timok.Dabba.Messages {
	internal class PriceChange {
		public int ProductId { get; private set; }
		public decimal Price { get; private set; }

		public PriceChange(int pID, decimal pPrice) {
			ProductId = pID;
			Price = pPrice;
		}
	}
}