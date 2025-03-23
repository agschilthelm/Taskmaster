using Microsoft.EntityFrameworkCore;

namespace TaskmasterApi
{
    public class TaskmasterDbContext : DbContext
    {
        public TaskmasterDbContext(DbContextOptions<TaskmasterDbContext> options) : base(options)
        {

        }

        public DbSet<TaskmasterModels.Category> Categories { get; set; }
        public DbSet<TaskmasterModels.Task> Tasks { get; set; }
        public DbSet<TaskmasterModels.Household> Households { get; set; }
        public DbSet<TaskmasterModels.Member> Members { get; set; }
        public DbSet<TaskmasterModels.TaskHistory> TaskHistories { get; set; }
    }
}
