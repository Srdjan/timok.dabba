using System;
using System.Collections.Generic;
using Timok.Dabba.Core;
using Timok.Dabba.Messages;

namespace Timok.Dabba.Model {
	internal class Product {
		//} : Base<T> {
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Description { get; private set; }
		public List<string> AvailableInStates { get; private set; }
		public decimal Price { get; private set; }

		//-- protected behaviour (cannot be invoked directly)
		public static void Consume(object pSender, GenericEventArgs<PriceChange> pArgs) {
			Console.WriteLine("Price change Consumed");
		}

		public static void Consume(object pSender, GenericEventArgs<AvailibiltyChange> pArgs) {
			Console.WriteLine("Availability change Consumed");
		}
	}
}