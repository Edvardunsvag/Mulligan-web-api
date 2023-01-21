using System;
using Microsoft.EntityFrameworkCore;
using MulliganApi.Models;

namespace MulliganApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=tcp:mulligan-sql-server.database.windows.net,1433;Initial Catalog=mulligan-sql-database;Persist Security Info=False;User ID=edvardhu;Password=SqlServer1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Hole> Holes { get; set; }
    }

}

