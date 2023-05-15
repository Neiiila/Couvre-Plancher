using Couvre_Plancher.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Couvre_Plancher.Controllers
{
    public class ProduitsController : Controller
    {
        // GET: ProduitsController1
        private readonly DbContextClass _context;

        public ProduitsController(DbContextClass context)
        {
            _context = context;
        }

        public ActionResult ProductList( )
        {
            var data = _context.couvrePlanches.ToList();
            return View(data);
        }

        // GET: ProduitsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitsController1/Create
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

        public ActionResult AddProduct()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult AddProduct( int id, string titre, string prix, string imgLink, string description )
        {
            CouvrePlanche c = new CouvrePlanche();
            c.Id = id ;
            c.ImgLink = imgLink;
            c.Prix = float.Parse(prix);
            c.Titre = titre; 
            _context.Add(c);
            _context.SaveChanges();
            return View();
        }
        public ActionResult EditForm(int id)
        {
            var data = _context.couvrePlanches.Where(x => x.Id == id).SingleOrDefault();

            return View(data); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditForm(int id , string titre , string prix , string imgLink , string description )
        {
            var data = _context.couvrePlanches.Where(x => x.Id == id).SingleOrDefault();
            data.Titre = titre;
            data.Prix = float.Parse( prix ) ; 
            data.ImgLink = imgLink;
            data.Description = description;
            _context.SaveChanges();
            return RedirectToAction("ProductList" , "Produits"); 
        }
        // GET: ProduitsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitsController1/Edit/5
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

        // GET: ProduitsController1/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _context.couvrePlanches.FirstOrDefault( x => x.Id == id);
            if( data != null)
            {
                _context.couvrePlanches.Remove(data);
                _context.SaveChanges();
            } 
            return RedirectToAction("ProductManage");
        }

        // POST: ProduitsController1/Delete/5
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
