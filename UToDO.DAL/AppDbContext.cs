using Microsoft.EntityFrameworkCore;
using UToDO.DAL.Entities;

namespace UToDO.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(@"Data Source=tasks.db");
    }
}