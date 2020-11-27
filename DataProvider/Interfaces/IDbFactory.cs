namespace DataProvider.Interfaces
{
    public interface IDbFactory
    {
        LicenseDbContext Db { get; }
    }
}