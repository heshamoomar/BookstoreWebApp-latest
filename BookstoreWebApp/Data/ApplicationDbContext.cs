using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookstoreWebApp.Models;

namespace BookstoreWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookstoreWebApp.Models.Book> Book { get; set; } = default!;
        public DbSet<Book> Books { get; set; }
    }
}