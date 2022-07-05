using SinhalaTutorial.Models;

namespace SinhalaTutorial.Services.Authors;

public interface IAuthorRepository
{
    public List<Author> GetAllAuthors();
    public Author GetAuthor(int id);
}