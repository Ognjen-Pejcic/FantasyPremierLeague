using Data.UnitOfWork;
using Fantasy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
       
        public UserController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model) 
        {
            try
            {
            User user = unitOfWork.User.GetByUsernameAndPasswor(new User
            {
                Email = model.Email,
                Password = model.Password
            }) ;

                HttpContext.Session.SetInt32("userid", user.UserId);
                HttpContext.Session.SetString ("email", user.Email);
                //ViewBag.IsLoggedIn = true;
                return RedirectToAction("Index", "Squad");

            }catch(Exception e)
            {
                ModelState.AddModelError(string.Empty, "Wrong credidentials");
                return View();  
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Register")]
        public ActionResult Register(LoginViewModel model)
        {
            try
            {
                if(unitOfWork.User.Search(u=>u.Email == model.Email).Any())
                {
                    ModelState.AddModelError(string.Empty, "Username is taken!");
                    return View();
                }
                unitOfWork.User.Add(new User
                {
                    Email = model.Email,
                    Password = model.Password,
                    Name = model.Name,
                    Surname = model.Surname,
                    TeamName = model.TeamName
                }) ;
              
                //ViewBag.IsLoggedIn = true;
                unitOfWork.Commit();
                return Index();

            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Wrong credidentials");
                return View();
            }
        }


       
        public ActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index");
            
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
