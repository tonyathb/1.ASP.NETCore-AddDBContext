using ASPCatSpace.Data;
using ASPCatSpace.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCatSpace.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public CatSpaceContext CatSpaceContext { get; private set; }
        public HomeController(CatSpaceContext context)
        {
            this.CatSpaceContext = context;
        }
        
       

        public IActionResult Index()
        {
            var cats = this.CatSpaceContext.Cat.ToList();

            return this.View(cats);  //(model:cats);
        }
        public IActionResult About()
        {
            return View();
                //Content("Tuk shte ima nesto za nas");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
