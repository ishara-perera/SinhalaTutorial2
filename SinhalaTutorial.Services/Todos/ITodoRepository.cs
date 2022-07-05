using SinhalaTutorial.Models;

namespace SinhalaTutorial.Services.Todos;

public interface ITodoRepository
{
    public List<Todo> AllTodos();
    public Todo GetTodo(int id);
}