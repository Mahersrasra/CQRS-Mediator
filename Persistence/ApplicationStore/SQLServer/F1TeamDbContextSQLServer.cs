using Microsoft.EntityFrameworkCore;

namespace Persistence.ApplicationStore.SQLServer
{
    public class F1TeamDbContextSQLServer : DbContext
    {
        public F1TeamDbContextSQLServer(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.F1Team>(builder =>
            {
                builder.ToTable("F1Teams");
                builder.HasKey(team => team.Id);
                builder.Ignore(team => team.TeamDrivers);
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Domain.Entities.F1Team> f1Teams { get; set; }
    }
}
