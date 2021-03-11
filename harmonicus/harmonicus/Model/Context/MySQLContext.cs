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
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
