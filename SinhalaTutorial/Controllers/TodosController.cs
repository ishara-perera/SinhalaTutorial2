using Microsoft.AspNetCore.Mvc;
using SinhalaTutorial.Models;
using SinhalaTutorial.TodoServices;

namespace SinhalaTutorial.Controllers;

public class TodosController : Controller
{
    private TodoService _todoService;
    public TodosController()
    {
        _todoService = new TodoService();
    }
    [HttpGet("{id}")]
    public ActionResult GetTodos(int? id)
    {
        
        var allTodos = _todoService.AllTodos();
        if (id is null) return Ok(allTodos);
        allTodos = allTodos.Where(t => t.Id == id).ToList();
        return Ok(allTodos);
    }
}