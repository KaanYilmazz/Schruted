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


        public SchrutedDbContext(DbContextOptions<SchrutedDbContext> options)
            : base(options)
        {
        }
    }
}
