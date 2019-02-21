using Microsoft.EntityFrameworkCore;

namespace Library.API.Entities
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
            : base(options)
        {
           
        }
        public DbSet<FriendConnection> Friends { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
