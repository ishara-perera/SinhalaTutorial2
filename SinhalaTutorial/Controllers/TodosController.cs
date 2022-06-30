using Microsoft.AspNetCore.Mvc;
using SinhalaTutorial.TodoServices;

namespace SinhalaTutorial.Controllers;

public class TodosController : Controller
{
    private readonly ITodoRepository _todoService;
    public TodosController(ITodoRepository repository)
    {
        _todoService = repository;
    }
    
    [HttpGet("{id?}")]
    public ActionResult GetTodos(int? id)
    {
        var allTodos = _todoService.AllTodos();
        if (id is null) return Ok(allTodos);
        allTodos = allTodos.Where(t => t.Id == id).ToList();
        return Ok(allTodos);
    }
}