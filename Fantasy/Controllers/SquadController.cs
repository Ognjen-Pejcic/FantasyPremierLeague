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
            IUnitOfWork uow = new FantasyUnitOfWork(new FantasyContext());
            List<Squad> Squads = uow.Squad.GetAllWithUser();
            return View(Squads);
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

            List<SelectListItem> selectList = players.Select(s => new SelectListItem { Text = s.Name + " " + s.Surname + " | "  + s.Team.TeamName + " | $" + s.Price + " mill", Value = s.PlayerId.ToString() }).ToList();


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

            if (model.Squad.Players.Where(p => p.Position == Position.GKP).Count() != 2 ||
                model.Squad.Players.Where(p => p.Position == Position.DEF).Count() != 5 ||
                model.Squad.Players.Where(p => p.Position == Position.MID).Count() != 5 ||
                model.Squad.Players.Where(p => p.Position == Position.FWD).Count() != 3)
            {

                _notyf.Error("Squad must have 2 GKP, 5 DEF, 5 MID and 3 FWD");
                return RedirectToAction("Create");
            }




            try
            {
                int userid =(int)HttpContext.Session.GetInt32("userid");
                User u = unitOfWork.User.FindById(userid);
                model.Squad.User = u;
                unitOfWork.Squad.Add(model.Squad);
                unitOfWork.Commit();
                return RedirectToAction("Index", "Player");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);

                return RedirectToAction("Create");
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
