using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Schruted.EntityFrameworkCore
{
    public static class SchrutedDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchrutedDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchrutedDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
