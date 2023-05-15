using Couvre_Plancher.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics; 

namespace Couvre_Plancher.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbContextClass _context;


        public HomeController(ILogger<HomeController> logger , DbContextClass context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {

            //Superviseur superviseur = new Superviseur("LB122790", "Youssef El Assaoui", Convert.ToDateTime("07/01/2002"), "28 Khalid Ibn El Oualid, Tanger ", "0666811923", "Kid_china", "elassaoui.youssef@gmail.com", "5678"); 
            //_context.superviseurs.Add(superviseur);
            //_context.SaveChanges(); 
            return View();
        }
        
        public IActionResult terms_of_use()
        {
            Console.WriteLine(HttpContext.Session.GetString("username") + "this name from index ");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}