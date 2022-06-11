using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zeroToHeroMVC.Models;

namespace zeroToHeroMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DenemeData = "deneme viewbag partial";
            User u1 = new User
            {
                LastName = "denmeLast"
            };
            return View(u1);
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return View();
        }

        //Header ile request yakalama
        public  IActionResult headerData()
        {
            var headers = Request.Headers.ToList(); // üzerinden yakalanır. header data catching way.
            return View();
        }



    }
}
