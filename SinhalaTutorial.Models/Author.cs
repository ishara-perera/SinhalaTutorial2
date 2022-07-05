using System.ComponentModel.DataAnnotations;

namespace SinhalaTutorial.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }
    public string FullName { get; set; }
}