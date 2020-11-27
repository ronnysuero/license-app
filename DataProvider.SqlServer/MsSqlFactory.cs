using DataProvider.Interfaces;

namespace DataProvider.SqlServer
{
    public class MsSqlFactory : IDbFactory
    {
        private readonly MsSqlServerDb _db;

        public MsSqlFactory(MsSqlServerDb db)
        {
            _db = db;
        }

        public LicenseDbContext Db => _db;
    }
}