using SinhalaTutorial.DataAccess;
using SinhalaTutorial.Models;

namespace SinhalaTutorial.Services.Todos;

public class TodoSqlServerService : ITodoRepository
{
    private readonly TodoDbContext _context = new TodoDbContext();
   
    public List<Todo> AllTodos()
    {
        return _context.Todos.ToList();
    }

    public Todo GetTodo(int id)
    {
        var todo = _context.Todos.Find(id);
        return todo;
    }
    
}