using Microsoft.EntityFrameworkCore;
using MulliganApi.Database.Models;

namespace MulliganApi.Database
{
    public class MulliganDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MulliganDbContext(DbContextOptions<MulliganDbContext> options, IConfiguration config) : base(options)
        {
            _configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.
                UseSqlServer("Server=tcp:mulligan-dbserver-test.database.windows.net,1433;Initial Catalog=mulligan-db-test;Persist Security Info=False;User ID=mulligan-login;Password=HoleInOne1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Round> Round { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseHole> CourseHole { get; set; }
        public DbSet<CourseTeeBox> TeeBoxes { get; set; }
        public DbSet<RoundHole> RoundHole { get; set; }
        public DbSet<Note> Note { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new MulliganDbContetxtInitializer(modelBuilder).Seed();
        }
    }
}

