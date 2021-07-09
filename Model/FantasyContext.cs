using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.Domain;
using System;

namespace Model
{
    public class FantasyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Squad> Squads { get; set; }
        //public DbSet<PlayerSquadOption> PlayerSquadOptions { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerGameStatistics> PlayerGameStatistics { get; set; }
        public DbSet<Player> Players { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory).EnableSensitiveDataLogging()
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fantasy12345;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>().HasMany(e => e.Squads).WithOne(u => u.User);
            //modelBuilder.Entity<Squad>().HasMany(e => e.Players).WithMany(u => u.);
            modelBuilder.Entity<Squad>().HasKey(e => new { e.SquadId, e.UserId });
            modelBuilder.Entity<PlayerGameStatistics>().HasKey(e => new { e.PlayerId, e.GameId });
            //modelBuilder.Entity<PlayerSquadOption>().HasKey(e => new { e.PlayerId, e.SquadId, e.UserId });


            Seed(modelBuilder);


        }
        private static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(new Team
            {
                Name = "Leeds",ID=5
            });

        }
    }
}
