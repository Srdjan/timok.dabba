namespace Timok.Dabba.Messages {
	internal class AvailibiltyChange {
		public int ProductId { get; private set; }
		public string State { get; private set; }

		public AvailibiltyChange(int pID, string pStateAbr) {
			ProductId = pID;
			State = pStateAbr;
		}
	}
}