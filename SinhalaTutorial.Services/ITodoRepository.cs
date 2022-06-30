using SinhalaTutorial.Models;

namespace SinhalaTutorial.TodoServices;

public interface ITodoRepository
{
    public List<Todo> AllTodos();
}