 using Data.UnitOfWork;
using Fantasy.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Controllers
{
    [LoggedInUser]
    public class PlayerController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public PlayerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // GET: PlayerController
        
        public ActionResult Index()
        {
            List<Player> players = unitOfWork.Player.GetAll();
            int? userid = HttpContext.Session.GetInt32("userid");
            if (userid != null)
            {
                ViewBag.IsLoggedIn = true;
                
            }
            else
            {
              return   RedirectToAction("Index", "User");
            }
            return View(players);
        }

        // GET: PlayerController/Details/5
        public ActionResult Details([FromRoute(Name = "id")] int playerId)
        {
            Player player = unitOfWork.Player.FindById(playerId);
            return View(player);
        }

        // GET: PlayerController/Create
        [HttpGet]
        public ActionResult Create()
        {
            List<SelectListItem> teams = new List<SelectListItem>();
            foreach (Team t in unitOfWork.Team.GetAll())
            {
                teams.Add(new SelectListItem
                {
                    Value = t.ID.ToString(),
                    Text = t.TeamName
                });
            }
            ViewData["Teams"] = teams;
            ViewBag.Teams = teams;
            return View();
            //return View("CreatePlayer");
        }
        [HttpPost]
       // [ActionName("CreatePlayer")]
        [ValidateAntiForgeryToken]
        public ActionResult  CreatePlayer([FromForm]Player player)
        {
           
            if (!ModelState.IsValid)
            {
                return View("Create"); 
            }

            bool exists = unitOfWork.Player.Search(k=>k.Name == player.Name).Any();
            if (exists)
            {
                ModelState.AddModelError("Name", "Name Already Exist");
                return View("Create");
            }
            unitOfWork.Player.Add(player);
            unitOfWork.Commit();
            return Index();
           
        }

        // POST: PlayerController/Create
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

        // GET: PlayerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlayerController/Edit/5
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

        // GET: PlayerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlayerController/Delete/5
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
