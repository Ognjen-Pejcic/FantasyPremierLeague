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

        public SquadController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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

            List<SelectListItem> selectList = players.Select(s => new SelectListItem { Text = s.Name, Value = s.PlayerId.ToString() }).ToList();
            ViewBag.Players = selectList;
            CreateSquadViewModel model = new CreateSquadViewModel
            {
                Players = selectList
            };
            return View(model);
        }

        // POST: SquadController/Create
        [HttpPost]
        [ActionName("CreateSquad")]   
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateSquadViewModel model)
        {
            try
            {
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
