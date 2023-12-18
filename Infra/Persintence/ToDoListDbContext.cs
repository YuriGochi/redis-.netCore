
using Microsoft.EntityFrameworkCore;
using netcore_redis.Core.Entities;

namespace netcore_redis.Infra.Persintence
{
    public class ToDoListDbContext : DbContext
    {
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDo>()
                .HasKey(t => t.Id);
        }
    }
}
