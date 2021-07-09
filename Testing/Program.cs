using Data;
using Data.Implementation;
using Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Team team = new Team
            //{
            //    TeamName = "Arsenal"

            //};

            ApiPodaci a = new ApiPodaci();

            using FantasyContext context = new FantasyContext();
            var data =ApiPodaci.GetData();
            //context.Add(team);
            //context.SaveChanges();

            //List<Team> teams = context.Teams.ToList();
            //Team t1 = teams[2];
            //t1.TeamName = "Aston VIlla";
            // context.SaveChanges();

            // Team t1 = context.Teams.First(t => t.TeamName == "Arsenal");

            // Player p = new Player { team
            //, Name = "Alexander",Position = Position.FWD, Surname = "Laccazet"
            // };
            // context.Add(p);
            // context.SaveChanges();


            //Player p = context.Players.Include(s=>s.Team).Single(s=>s.PlayerId==1);
            //Console.WriteLine(p.Name + " " + p.Team.TeamName);

            #region update
            //List<Player> players = context.Players.Include(p => p.Team).ToList();
            //using FantasyContext f = new FantasyContext();
            //Player p = players[0];
            //f.Attach(p);
            //p.Team.TeamName = "Aston villa";
            ////tatjani nije uspelo samo sa ovim vec koristi i :
            //f.Entry(p.Team).State = EntityState.Modified;
            //f.Update(p);
            //f.SaveChanges();
            #endregion
            // teams.ForEach(d => Console.WriteLine(d.TeamName));
            //Team t = context.Teams.Include(p=>p.Players).First(k=>k.ID==2);
            //t.Players.Add(new Player
            //{
            //    Name = "Pierre Emerick",
            //    Position = Position.FWD,
            //    Surname = "Aubameyandssssssg"
            //});
            //context.SaveChanges();

            //ModelBuilder mb = new ModelBuilder();
            //mb.Entity<Team>().HasData(new Team { 
            //TeamName = "Leeds"});
            //var teams = context.Teams.Select(s => new
            //{
            //    s.TeamName,
            //    Players = s.Players.Select(p => new { p.Name, p.Surname })
            //}).ToList();


            using  IUnitOfWork uow = new FantasyUnitOfWork(new FantasyContext());
            uow.Squad.Add(new Squad());
            uow.Commit();
            context.Dispose();
        }

            

    
    }
}
