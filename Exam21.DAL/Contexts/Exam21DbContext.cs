using System.Reflection;

namespace Exam21.DAL.Contexts
{
    public class Exam21DbContext : DbContext
    {
        public Exam21DbContext(DbContextOptions options) : base(options) { }
        public DbSet<Portfolio> Portfolios {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
