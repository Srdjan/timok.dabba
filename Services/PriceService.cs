using System;
using Timok.Dabba.Core;
using Timok.Dabba.Messages;

namespace Timok.Dabba.Services {
	internal class PriceService {
		public event EventHandler<GenericEventArgs<PriceChange>> PriceChangeEvent;
		public event EventHandler<GenericEventArgs<AvailibiltyChange>> AvailabilityChangeEvent;

		public void Update(int pProductId, decimal pPrice) {
			PriceChangeEvent.Raise(this, new PriceChange(pProductId, pPrice));
		}

		public void Update(int pID, string pStateAbr) {
			AvailabilityChangeEvent.Raise(this, new AvailibiltyChange(pID, pStateAbr));
		}
	}
}