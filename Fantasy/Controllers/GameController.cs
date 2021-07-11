using AspNetCoreHero.ToastNotification.Abstractions;
using Data.UnitOfWork;
using Fantasy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Controllers
{
    public class GameController : Controller
    {
        
        private readonly IUnitOfWork unitOfWork;
        private readonly INotyfService _notyf;

        public GameController(IUnitOfWork unitOfWork, INotyfService notyf)
        {
            ViewBag.Generated = false;
            this.unitOfWork = unitOfWork;
            this._notyf = notyf;
        }

        // GET: GameController
        public ActionResult Index(AddGameStatsViewModel model)
        {
            IUnitOfWork uow = new FantasyUnitOfWork(new FantasyContext());
            List<Team> teams = unitOfWork.Team.GetAll();

            List<SelectListItem> selectList = teams.Select(s => new SelectListItem { Text = s.TeamName , Value = s.ID.ToString() }).ToList();



            //AddGameStatsViewModel model = new AddGameStatsViewModel
            //{
            //    Teams = selectList,

            //};
            model.Teams = selectList;
            return View(model);
          
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameController/Create

        [HttpPost]
     
  
        public ActionResult Generate(AddGameStatsViewModel model)
        {
            ViewBag.Generated = true;

            model.Game = new Game();
            model.Players = new List<Player>();
            model.Game.Home = unitOfWork.Team.FindById(model.HomeID);
            model.Game.Away = unitOfWork.Team.FindById(model.AwayID);

            List<Player> players = new List<Player>();

            List<Player> homeplaayers = unitOfWork.Player.GetAllByTeam(model.Game.Home);
            List<Player> awayplayers = unitOfWork.Player.GetAllByTeam(model.Game.Away);


            foreach (var item in homeplaayers)
            {
                players.Add(item);
            }
            foreach (var item in awayplayers)
            {
                players.Add(item);
            }
            model.Players = players;

            return PartialView("PlayersTableView", model);
        }



        [HttpPost]
        [ActionName("CreateGame")]
  
        public ActionResult Create(AddGameStatsViewModel model)
        {
            unitOfWork.Game.Add(model.Game);
            unitOfWork.Commit();
            foreach(PlayerGameStatistics stat in model.Stats)
            {
                var data = unitOfWork.Game.GetAll();
                stat.Game = data.OrderByDescending(p => p.GameId).FirstOrDefault();
                stat.Player = unitOfWork.Player.FindById(stat.PlayerId);
                unitOfWork.Statistics.Add(stat);
            }
            unitOfWork.Commit();

            List<Squad> squads = unitOfWork.Squad.GetSquadByGW(model.Game.GameWeek);
            foreach(var squad in squads)
            {
                foreach(var player in squad.Players)
                {
                    foreach(var playedPlayers in model.Stats)
                    {
                        if(playedPlayers.PlayerId == player.PlayerId)
                        {
                            if (squad.Captain == player.PlayerId && playedPlayers.MinutsPlayed>0)
                            {
                                squad.GameWeekPoints += 2 * playedPlayers.Points;
                                continue;
                            }
                            else if(squad.ViceCaptain == player.PlayerId )
                            {
                                squad.GameWeekPoints += 2 * playedPlayers.Points;
                            }
                            else
                            {
                                squad.GameWeekPoints += playedPlayers.Points;
                            }
                            
                        }
                    }
                }
                unitOfWork.Squad.Update(squad);
            }
           
            unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
