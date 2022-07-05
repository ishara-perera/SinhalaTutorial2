using Microsoft.AspNetCore.Mvc;
using SinhalaTutorial.Services.Authors;

namespace SinhalaTutorial.Controllers;

public class AuthorsController : Controller
{
    private readonly IAuthorRepository _service;

    public AuthorsController(IAuthorRepository service)
    {
        _service = service;
    }
    
    [HttpGet("authors")]
    public IActionResult GetAllAuthors()
    {
        var authors = _service.GetAllAuthors();
        return Ok(authors);
    }

    [HttpGet("authors/{id}")]
    public IActionResult GetAuthor(int id)
    {
        var author = _service.GetAuthor(id);
        if (author is null)
            return NotFound();
        return Ok(author);
    }
}