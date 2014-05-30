using System;
using Timok.Dabba.Core;

namespace Timok.Dabba.Model {
  internal abstract class Base<T> {
    public static void Consume(object pSender, GenericEventArgs<Message<T>> pArg) {
      Console.WriteLine("Message: [" + pArg.Payload.Name + "] received");
    }

    protected abstract int Consume(T pMessageContent);
  }
}