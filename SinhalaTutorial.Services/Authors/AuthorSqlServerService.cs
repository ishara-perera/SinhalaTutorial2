using SinhalaTutorial.DataAccess;
using SinhalaTutorial.Models;

namespace SinhalaTutorial.Services.Authors;

public class AuthorSqlServerService : IAuthorRepository
{
    private readonly TodoDbContext _context = new TodoDbContext();
    
    public List<Author> GetAllAuthors()
    {
        return _context.Authors.ToList();
    }

    public Author GetAuthor(int id)
    {
        return _context.Authors.Find(id);
    }
}