using AspNetCoreHero.ToastNotification.Abstractions;
using Data.UnitOfWork;
using Fantasy.Filters;
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


namespace Fantasy.Views
{
    [LoggedInUser]
    public class SquadController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly INotyfService _notyf;

        public SquadController(IUnitOfWork unitOfWork, INotyfService notyf)
        {
            this.unitOfWork = unitOfWork;
            this._notyf = notyf;
        }
        // GET: SquadController
        public ActionResult Index()
        {
            int? userid = HttpContext.Session.GetInt32("userid");
            if (userid != null)
            {
                ViewBag.IsLoggedIn = true;
            }
            else
            {
                return RedirectToAction("Index", "User");
            }

         

            if (HttpContext.Session.GetInt32("gw") == null)
                HttpContext.Session.SetInt32("gw", FindCurrentGeamWeek());

            Squad squad = unitOfWork.Squad.GetSquadForUser((int)HttpContext.Session.GetInt32("userid"), (int)HttpContext.Session.GetInt32("gw"));
            if (squad == null)
                return RedirectToAction("Create", "Squad");
            SquadViewModel svm = fillSquadViewModel(squad, unitOfWork);
            svm.GWPoints = squad.GameWeekPoints;
            svm.Gameweek = (int)HttpContext.Session.GetInt32("gw");
            svm.MaxGameWeek = FindCurrentGeamWeek();

            svm.stats = new List<PlayerGameStatistics>();
            PlayerGameStatistics gk = unitOfWork.Statistics.GetbygwID(svm.Gameweek, svm.Goalkeeper.PlayerId);
            svm.stats.Add(gk);

            foreach(var item in svm.DefenderLine)
            {
                PlayerGameStatistics def = unitOfWork.Statistics.GetbygwID(svm.Gameweek, item.PlayerId);
                svm.stats.Add(def);
            }
            foreach (var item in svm.MidfielderLine)
            {
                PlayerGameStatistics mid = unitOfWork.Statistics.GetbygwID(svm.Gameweek, item.PlayerId);
                svm.stats.Add(mid);
            }
            foreach (var item in svm.AttackLine)
            {
                PlayerGameStatistics att = unitOfWork.Statistics.GetbygwID(svm.Gameweek, item.PlayerId);
                svm.stats.Add(att);
            }


            return View(svm);
        }
        private SquadViewModel fillSquadViewModel(Squad squad, IUnitOfWork uow)
        {
            SquadViewModel svm = new SquadViewModel();
            svm.StartLine = squad.Players.FindAll(p => p.PlayerId != squad.Benched1 && p.PlayerId != squad.Benched2 && p.PlayerId != squad.Benched3 && p.PlayerId != squad.Benched4);

            svm.Goalkeeper = squad.Players.First(p => (int)p.Position == 1 && p.PlayerId != squad.Benched1
            && p.PlayerId != squad.Benched2 && p.PlayerId != squad.Benched3 && p.PlayerId != squad.Benched4);

            svm.Bench = squad.Players.FindAll(p => p.PlayerId == squad.Benched1 || p.PlayerId == squad.Benched2 || p.PlayerId == squad.Benched3 || p.PlayerId == squad.Benched4).ToList();

            svm.DefenderLine = squad.Players.FindAll(p => (int)p.Position == 2 && p.PlayerId != squad.Benched1
            && p.PlayerId != squad.Benched2 && p.PlayerId != squad.Benched3 && p.PlayerId != squad.Benched4).ToList();

            svm.MidfielderLine = squad.Players.FindAll(p => (int)p.Position == 3 && p.PlayerId != squad.Benched1
            && p.PlayerId != squad.Benched2 && p.PlayerId != squad.Benched3 && p.PlayerId != squad.Benched4).ToList();

            svm.AttackLine = squad.Players.FindAll(p => (int)p.Position == 4 && p.PlayerId != squad.Benched1
            && p.PlayerId != squad.Benched2 && p.PlayerId != squad.Benched3 && p.PlayerId != squad.Benched4).ToList();

            svm.TeamName = uow.User.FindById((int)HttpContext.Session.GetInt32("userid")).TeamName;


            return svm;
        }

        public ActionResult ChangeGameWeek(int gw)
        {
            HttpContext.Session.SetInt32("gw", gw);
            return Index();
        }
        private int FindCurrentGeamWeek()
        {
            List<Squad> squads = unitOfWork.Squad.GetAll().ToList();
            try
            {
                int gameweek = squads.Max(s => s.GameWeek);
                if (gameweek != 0)
                    return gameweek;
                else return 1;
            }
            catch
            {
                return 1;
            }
           

        }

        // GET: SquadController/Details/5
        public ActionResult Details([FromRoute(Name = "id")] int idSquad)
        {
            Squad model = unitOfWork.Squad.FindById(idSquad);
            return View();
        }

        // GET: SquadController/Create
        public ActionResult Create()
        {
            int? userid = HttpContext.Session.GetInt32("userid");
            if (userid != null)
            {
                ViewBag.IsLoggedIn = true;

            }
            else
            {
                return RedirectToAction("Index", "User");
            }

            //List<PlayerSquadOption> players = unitOfWork.Players.GetAll();
            List<Player> players = unitOfWork.Player.GetAll();

            List<SelectListItem> selectList = players.Select(s => new SelectListItem { Text = s.Name + " " + s.Surname + " | " +s.Position + " | " +s.Team.TeamName + " | $" + s.Price + " mill", Value = s.PlayerId.ToString() }).ToList();


            List<Player> playersG = unitOfWork.Player.Search(u=>u.Position==Position.GKP);
            List<SelectListItem> selectListG = playersG.Select(s => new SelectListItem { Text = s.Name +" " +s.Surname, Value = s.PlayerId.ToString() }).ToList();
            List<Player> playersD = unitOfWork.Player.Search(u => u.Position == Position.DEF);
            List<SelectListItem> selectListD = playersD.Select(s => new SelectListItem { Text = s.Name + " " + s.Surname, Value = s.PlayerId.ToString() }).ToList();
            List<Player> playersM = unitOfWork.Player.Search(u => u.Position == Position.MID);
            List<SelectListItem> selectListM = playersM.Select(s => new SelectListItem { Text = s.Name + " " + s.Surname, Value = s.PlayerId.ToString() }).ToList();
            List<Player> playersF = unitOfWork.Player.Search(u => u.Position == Position.FWD);
            List<SelectListItem> selectListF = playersF.Select(s => new SelectListItem { Text = s.Name + " " + s.Surname, Value = s.PlayerId.ToString() }).ToList();

            ViewBag.Players = selectList;
            CreateSquadViewModel model = new CreateSquadViewModel
            {
                Players = selectList,
                PlayersGKP = selectListG,
                PlayersDEF = selectListD,
                PlayersMID = selectListM,
                PlayersFWD = selectListF
            };
            return View(model);
        }

        // POST: SquadController/Create
        [HttpPost]
        [ActionName("CreateSquad")]
        [ValidateAntiForgeryToken]
        public  ActionResult Create(CreateSquadViewModel model)
        {
            if (model.Squad.Players.Count() != 15)
            {

                _notyf.Error("Squad must have 15 players");
                return RedirectToAction("Create");
            }
            List<Player> newpl = new List<Player>();
            foreach (var item in model.Squad.Players)
            {
                newpl.Add(unitOfWork.Player.FindById(item.PlayerId));

            }

            if (newpl.Where(p => p.Position == Position.GKP).Count() != 2 ||
                newpl.Where(p => p.Position == Position.DEF).Count() != 5 ||
               newpl.Where(p => p.Position == Position.MID).Count() != 5 ||
                newpl.Where(p => p.Position == Position.FWD).Count() != 3)
            {

                _notyf.Error("Squad must have 2 GKP, 5 DEF, 5 MID and 3 FWD");
                return RedirectToAction("Create");
            }
            int[] a =
            {
                model.Squad.Benched1 , model.Squad.Benched2 , model.Squad.Benched3, model.Squad.Benched4
            };
            if (a.Distinct().Count() != 4)
            {
                _notyf.Error("All benched players must be different");
                return RedirectToAction("Create");
            }

            if (model.Squad.Captain == model.Squad.ViceCaptain)
            {
                _notyf.Error("Captain cannot be same as vice-captain");
                return RedirectToAction("Create");
            }
            if (newpl.Sum(p => p.Price) > 100)
            {
                _notyf.Error("Your team price is over 100 mill");
                return RedirectToAction("Create");
            }

            try
            {
                int userid =(int)HttpContext.Session.GetInt32("userid");
                User u = unitOfWork.User.FindById(userid);
                model.Squad.User = u;
                unitOfWork.Squad.Add(model.Squad);
                unitOfWork.Commit();
                _notyf.Success("Squad saved");
                return RedirectToAction("Index", "Player");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                return RedirectToAction("Index");
            }
        }

        // GET: SquadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SquadController/Edit/5
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

        // GET: SquadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SquadController/Delete/5
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

        [HttpPost]
        public ActionResult AddPlayer(PlayerViewModel model)
        {
            Player p = unitOfWork.Player.FindById(model.PlayerId);
            PlayerViewModel model1 = new PlayerViewModel
            {
                Num = model.Num,
                PlayerId = p.PlayerId,
                Name = p.Name,
                Price = p.Price,
                SurName = p.Surname,
                Position = p.Position,
                Team = p.Team
            };
            return PartialView("SquadPlayerView", model1);
        }

        [HttpGet]
        public void CheckIfPlayersCouldRotate(int activePlayerId, int benchedPlayerId)
        {
            Squad squad = unitOfWork.Squad.GetSquadForUser((int)HttpContext.Session.GetInt32("userid"), (int)HttpContext.Session.GetInt32("gw"));




            if (squad.Benched1 == benchedPlayerId)
                squad.Benched1 = activePlayerId;
            else if (squad.Benched2 == benchedPlayerId)
                squad.Benched2 = activePlayerId;
            else if (squad.Benched3 == benchedPlayerId)
                squad.Benched3 = activePlayerId;
            else if (squad.Benched4 == benchedPlayerId)
                squad.Benched4 = activePlayerId;

            List<int> benched = new List<int> { (int)squad.Benched1, (int)squad.Benched2, (int)squad.Benched3, (int)squad.Benched4 };

            //cheking goalkeepers players
            //if (benched.Contains())


            unitOfWork.Squad.Update(squad);
            unitOfWork.Commit();

        }

        public ActionResult AddOption(PlayerViewModel model)
        {
            Player p = unitOfWork.Player.FindById(model.PlayerId);
            PlayerViewModel model1 = new PlayerViewModel
            {
                Num = model.Num,
                PlayerId = p.PlayerId,
                Name = p.Name,
                SurName = p.Surname,
                Position = p.Position,
                Team = p.Team
            };
            return PartialView("OptionPlayerView", model1);
        }
    }
}
