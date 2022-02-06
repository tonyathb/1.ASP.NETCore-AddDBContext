using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCatSpace.Views.Cats
{
    public class AutoRWController : Controller
    {
        // GET: AutoRWController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AutoRWController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutoRWController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoRWController/Create
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

        // GET: AutoRWController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutoRWController/Edit/5
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

        // GET: AutoRWController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutoRWController/Delete/5
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
