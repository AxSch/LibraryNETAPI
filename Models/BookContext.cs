using Microsoft.EntityFrameworkCore;

namespace test_api.Models;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options){}
    
    public DbSet<Book> Books { get; set;  } = null!;
}