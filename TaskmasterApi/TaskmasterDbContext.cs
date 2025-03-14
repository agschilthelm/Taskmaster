using Microsoft.EntityFrameworkCore;

namespace TaskmasterApi
{
    public class TaskmasterDbContext : DbContext
    {
        public TaskmasterDbContext(DbContextOptions<TaskmasterDbContext> options) : base(options)
        {

        }

        //public TaskmasterDbContext(DbContextOptions options) : base(options)
        //{

        //}

        public DbSet<TaskmasterModels.Task> Tasks { get; set; }
    }
}
