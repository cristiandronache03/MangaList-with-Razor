using Microsoft.EntityFrameworkCore;

namespace MangaList_with_Razor.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
