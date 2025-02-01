using Microsoft.EntityFrameworkCore;
using ViewComponentLesson.Entities;

namespace ViewComponentLesson.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}