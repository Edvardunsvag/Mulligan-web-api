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
            
            var connectionString = _configuration.GetConnectionString("TestDb");

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.
                UseSqlServer(connectionString);
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserRatings> UserRating { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Round> Round { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseHole> CourseHole { get; set; }
        public DbSet<CourseTeeBox> TeeBoxes { get; set; }
        public DbSet<RoundHole> RoundHole { get; set; }
        public DbSet<Note> Note { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new MulliganDbContetxtInitializer(modelBuilder).Seed();
            modelBuilder.Entity<UserRatings>()
                .HasOne(ur => ur.User);

            
            base.OnModelCreating(modelBuilder);
        }
    }
}

