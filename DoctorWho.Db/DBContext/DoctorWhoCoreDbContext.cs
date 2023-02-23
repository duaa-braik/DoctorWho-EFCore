using DoctorWho.Db.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace DoctorWho.Db.DBContext
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        private void GetConnectionString(out string ConnectionString)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            ConnectionString = config["ConnectionString:SqlServer"];
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            GetConnectionString(out string ConnectionString);

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}