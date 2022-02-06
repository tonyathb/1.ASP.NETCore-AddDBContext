using ASPCatSpace.Data;
using ASPCatSpace.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCatSpace.Controllers
{
    public class CatsController : Controller
    {
        public CatSpaceContext Context { get; private set; }
        public CatsController(CatSpaceContext context)
        {
            this.Context = context;
        }
        public IActionResult Details(int id)
        {
            var cat = Context.Cat.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return View(cat);
        }

        [HttpGet]
        //[Route("/Cats/AddCat")]        
        public IActionResult AddCat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCat(Cat model)
        {
            this.Context.Cat.Add(model);
            this.Context.SaveChanges();

            return RedirectToAction("Details", new { id = model.Id });
           // return RedirectToRoute("default", new {controller="Cats", action="Details", id = model.Id });
        }
        [HttpGet]               
        public IActionResult UpdateViewCat(int id)
        {
            var catUpd=this.Context.Cat.Find(id);
            return View("UpdateCat",catUpd);
        }

        [HttpPost]
        //[Route("/Cats/UpdateCat")]
        public IActionResult UpdateCat(Cat model)
        {
            this.Context.Cat.Update(model);
            this.Context.SaveChanges();

            return RedirectToAction("Details", new { id = model.Id });
            // return RedirectToRoute("default", new {controller="Cats", action="Details", id = model.Id });
        }
    }
}
