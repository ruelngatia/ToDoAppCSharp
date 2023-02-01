using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.NewFolder
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
        public DbSet<TaskModel> Tasks { get; set; }

    }

}
