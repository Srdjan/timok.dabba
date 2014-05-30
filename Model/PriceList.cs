using System;
using Timok.Dabba.Core;
using Timok.Dabba.Messages;

namespace Timok.Dabba.Model {
	internal class PriceList {
		//-- readonly properties
		public Product Product { get; private set; }
		public decimal Price { get; private set; }

		//-- protected behaviour (cannot be invoked directly)
		public static void Consume(object pSender, GenericEventArgs<PriceChange> pArgs) {
			Console.WriteLine("Price change Consumed");
		}
	}
}