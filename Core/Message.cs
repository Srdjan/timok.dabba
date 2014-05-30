namespace Timok.Dabba.Model {
  internal class Message<T> {
    static int id;

    public int Id {
      get { return id; }
    }

    public string Name { get; private set; }
    public T Content { get; private set; }

    public Message(string pName) {
      id++;
      Name = pName;
    }
  }
}