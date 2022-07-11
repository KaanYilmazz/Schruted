using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Schruted.Authorization.Roles;
using Schruted.Authorization.Users;
using Schruted.MultiTenancy;
using Schruted.Domain;

namespace Schruted.EntityFrameworkCore
{
    public class SchrutedDbContext : AbpZeroDbContext<Tenant, Role, User, SchrutedDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<DoTask> DoTasks { get; set; }
        public DbSet<TaskHistory> TaskHistories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<WorkFile> WorkFiles { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<WorkLog> WorkLogs { get; set; }


        public SchrutedDbContext(DbContextOptions<SchrutedDbContext> options)
            : base(options)
        {
        }
    }
}
