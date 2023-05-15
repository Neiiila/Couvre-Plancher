using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Couvre_Plancher.Controllers
{
    public class CommandesController : Controller
    {
        // GET: CommandesController
        public ActionResult CommandList()
        {

            return View();
        }
    }
}
