using System;

namespace Timok.Dabba.Core {
	public class GenericEventArgs<T> : EventArgs {
		public T Payload { get; private set; }

		public GenericEventArgs(T pPayload) {
			Payload = pPayload;
		}
	}

	public static class EventExtensions {
		public static void Raise<T>(this EventHandler<GenericEventArgs<T>> pHandler, object pSender, T pPayload) {
			if (pHandler != null) {
				pHandler(pSender, new GenericEventArgs<T>(pPayload));
			}
		}
	}
}