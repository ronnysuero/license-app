using Microsoft.EntityFrameworkCore;

namespace DataProvider.SqlServer
{
    public class MsSqlServerDb : LicenseDbContext
    {
        public MsSqlServerDb(DbContextOptions options) : base(options)
        {
        }
    }
}