using Couvre_Plancher.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Couvre_Plancher.Controllers
{
    public class AuthentificationController : Controller
    {
        public readonly DbContextClass _context; 

        public AuthentificationController(DbContextClass context)
        {
            _context = context;
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(string email, string password)
        {

            var user = _context.superviseurs.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password)); 
            if(user != null)
            {
                HttpContext.Session.SetString("username", user.Username);
                HttpContext.Session.SetString("nom", user.Nom);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result  = false; 
                
            }
            return View();
        }

        public ActionResult ProductManage()
        {
            var data = _context.couvrePlanches.ToList(); 
            return View(data);
        }

        // GET: Authentification/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Authentification/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Authentification/Create
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

        // GET: Authentification/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Authentification/Edit/5
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

        // GET: Authentification/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Authentification/Delete/5
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
