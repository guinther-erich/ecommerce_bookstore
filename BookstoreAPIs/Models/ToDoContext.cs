using Microsoft.EntityFrameworkCore;

namespace BookstoreAPIs.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option)
            : base(option)
        {
        }

        public DbSet<Book> todoProducts { get; set;}
    }
}
