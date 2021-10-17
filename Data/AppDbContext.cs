using Microsoft.EntityFrameworkCore;
using MyFirstTodo.Models;

namespace MyFirstTodo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        
    }
}
