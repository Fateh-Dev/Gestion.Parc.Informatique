
using Microsoft.EntityFrameworkCore;
namespace Gestion.Parc.Informatique.Data;

public class SqliteDbContext : AppDbContext
{

    public SqliteDbContext(IConfiguration configuration) : base(configuration) { }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(Configuration.GetConnectionString("SqliteConnection"));
    }


}
