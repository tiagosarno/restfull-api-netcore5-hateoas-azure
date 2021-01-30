using Microsoft.EntityFrameworkCore;

namespace harmonicus.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}
        public DbSet<Psychologist> Psychologists { get; set; }
    }
}
