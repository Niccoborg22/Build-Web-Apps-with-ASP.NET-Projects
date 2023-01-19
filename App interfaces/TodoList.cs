class TodoList : IDisplayable, IResetable
  {
  public string[] Todos
  { get; private set; }

  private int nextOpenIndex;

  public TodoList()
  {
    Todos = new string[5];
    nextOpenIndex = 0;
  }

  public void Add(string todo)
  {
    Todos[nextOpenIndex] = todo;
    nextOpenIndex++;
  }

  // Method to satisfy the IDisplayable interface
  public void Display()
  {
    Console.WriteLine("TODO LIST");
    foreach(string todo in Todos){
      Console.WriteLine("- " + todo);
    }
  }

  // Method to satisfy the IResetable interface
  public void Reset()
  {
    Todos = new string[5];
    nextOpenIndex = 0;
  }
}