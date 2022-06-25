using Microsoft.AspNetCore.Mvc;

namespace SinhalaTutorial.Controllers;

public class TasksController : Controller
{
    [HttpGet("tasks")]
    public IActionResult Tasks()
    {   
        var tasks = new string[] { "Task1", "Task2", "Task3" };
        return Ok(tasks);
    }
    
    [HttpPost("create_task")]
    public IActionResult CreateTask()
    {
        return Ok();
    }
}