using System;
using Timok.Dabba.Model;
using Timok.Dabba.Services;

namespace Timok.Dabba.Container {
	public class Dabba {
		readonly PriceService priceService;

		public Dabba() {
			priceService = new PriceService();
			priceService.PriceChangeEvent += PriceList.Consume;
			priceService.PriceChangeEvent += Product.Consume;
		}

		public void Run() {
			priceService.Update(4, (decimal) 12.89);
			priceService.Update(4, "+NJ");
			Console.ReadLine();
		}
	}
}