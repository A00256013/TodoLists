using System.Collections.Generic;

namespace TodoList.API
{
    public class AppDbContext
    {
        // DbSet property for ToDoItem entity
        public DbSet<ToDoItem> ToDoItems { get; set; }

        // Constructor for AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
