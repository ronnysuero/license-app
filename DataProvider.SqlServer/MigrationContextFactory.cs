using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataProvider.SqlServer
{
    public class MigrationContextFactory : IDesignTimeDbContextFactory<MsSqlServerDb>
    {
        public MsSqlServerDb CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MsSqlServerDb>();

            builder.UseSqlServer(
                @"Data Source=.;Initial Catalog=DbLicenseApp;Integrated Security=true;MultipleActiveResultSets=True"
            );

            return new MsSqlServerDb(builder.Options);
        }
    }
}