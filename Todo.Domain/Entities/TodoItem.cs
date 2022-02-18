namespace Todo.Domain.Entities
{
  public class Todo : Entity
  {
    public Todo(string title, bool done, DateTime date, string user)
    {
      Title = title;
      Done = done;
      Date = date;
      User = user;
    }

    public string Title { get; private set; }
    public bool Done { get; private set; }
    public DateTime Date { get; private set; }
    public string User { get; private set; }
  }
}