using Microsoft.EntityFrameworkCore;
using UdemyCourse.Model.Models;

namespace UdemyCourse.DataAccess {
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}