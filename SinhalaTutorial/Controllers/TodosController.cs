using Microsoft.AspNetCore.Mvc;
using SinhalaTutorial.Services.Todos;

namespace SinhalaTutorial.Controllers;

public class TodosController : Controller
{
    private readonly ITodoRepository _todoService;
    public TodosController(ITodoRepository repository)
    {
        _todoService = repository;
    }
    
    [HttpGet("todo/{id}")]
    public IActionResult GetTodos(int id)
    {
        var todo = _todoService.GetTodo(id);
        if (todo is null)
            return NotFound();
        return Ok(todo);
    }

    [HttpGet("todos")]
    public IActionResult GetAllTodos()
    {
        var todos = _todoService.AllTodos();
        return Ok(todos);
    }
}