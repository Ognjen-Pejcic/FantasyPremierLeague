using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.Domain;
using System;
using System.Collections.Generic;

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
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fantasy1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
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
        public static void Seed(ModelBuilder modelBuilder)
        {
            ApiPodaci data = ApiPodaci.GetData();
            List<Teams> t = data.teams;
            List<Types> types = data.element_types;
            List<Player> players = new List<Player>();
            List<Team> tms = new List<Team>();
            int i = 0;
            foreach (var item in data.teams)
            {
                Team a = new Team();
                a.TeamName = item.name;
                a.ID = item.id;
                tms.Add(a);
            }
            modelBuilder.Entity<Team>().HasData(tms);


            foreach (var item in data.elements)
            {
                Player p = new Player();
                p.Name = item.first_name;
                p.Surname = item.second_name;
                p.PlayerId = item.id;
                p.TeamID = item.team;
                //p.Team = new Team
                //{
                //    ID = item.team
                //};
                p.Position = (Position)item.element_type;
                Random rnd = new Random();
                switch (p.Position)
                {
                    case Position.GKP:
                    case Position.DEF:

                        p.Price = rnd.Next(4, 7);

                        break;
                    case Position.MID:

                        p.Price = rnd.Next(5, 12);
                        break;
                    case Position.FWD:

                        p.Price = rnd.Next(7, 12);
                        break;

                }
                //if (i == 5) break;
                //i++;
                players.Add(p);
            }
            modelBuilder.Entity<Player>().HasData(players);

        }
    }
}
