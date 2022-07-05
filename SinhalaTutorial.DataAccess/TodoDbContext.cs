using Microsoft.EntityFrameworkCore;
using SinhalaTutorial.Models;

namespace SinhalaTutorial.DataAccess;

public class TodoDbContext : DbContext
{
    public DbSet<Todo> Todos { get; set; }

    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString =
            "Server=localhost\\SQLEXPRESS; Database=TodoDB; Trusted_Connection=True; TrustServerCertificate=True;";
        base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));

        //     var connectionString = "Server=localhost\\SQLEXPRESS; Database=TodoDB; Trusted_Connection=True; TrustServerCertificate=True;";
        //     base.OnConfiguring(new DbContextOptionsBuilder(optionsBuilder.UseSqlServer(connectionString).EnableSensitiveDataLogging().Options));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(new Author[]
        {
            new Author { AuthorId = 1, FullName = "Ishara Perera" },
            new Author { AuthorId = 2, FullName = "Ashan Nishantha" },
            new Author { AuthorId = 3, FullName = "Suranjith Geeshan" },
            new Author { AuthorId = 4, FullName = "Lahiru Mudalige" },
            new Author { AuthorId = 5, FullName = "Rachitha Wathsala" }
        });
        modelBuilder.Entity<Todo>().HasData(new Todo[]
        {
            new Todo
            {
                Id = 1,
                Title = "ASP.NET",
                Description = "Learn ASP.NET Sinhala Tutorial",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New,
                AuthorId = 1
            },
            new Todo
            {
                Id = 2,
                Title = "Python",
                Description = "Learn Python",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.Completed,
                AuthorId = 2
            },
            new Todo
            {
                Id = 3,
                Title = "Angular",
                Description = "Learn Angular Tutorial",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.New,
                AuthorId = 3
            }
        });
    }
}