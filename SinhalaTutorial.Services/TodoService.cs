using SinhalaTutorial.Models;
namespace SinhalaTutorial.TodoServices;

public class TodoService : ITodoRepository
{
    public List<Todo> AllTodos()
    {
        var todos = new List<Todo>();

        var todo1 = new Todo
        {
            Id = 1,
            Title = "ASP.NET",
            Description = "Learn ASP.NET Sinhala Tutorial",
            Created = DateTime.Now,
            Due = DateTime.Now.AddDays(4),
            Status = TodoStatus.New
        };
        todos.Add(todo1);

        var todo2 = new Todo
        {
            Id = 2,
            Title = "Angular",
            Description = "Learn Angular Tutorial",
            Created = DateTime.Now,
            Due = DateTime.Now.AddDays(4),
            Status = TodoStatus.InProgress
        };
        todos.Add(todo2);

        var todo3 = new Todo
        {
            Id = 3,
            Title = "C#",
            Description = "Learn C# Tutorial",
            Created = DateTime.Now,
            Due = DateTime.Now.AddDays(4),
            Status = TodoStatus.Completed
        };
        todos.Add(todo3);

        return todos;
    }
}