using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zeroToHeroMVC.Models;

namespace zeroToHeroMVC.Controllers
{
    public class VeriAlmaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        ////Birinci yontem. en ilkel yontem.
        //[HttpPost]
        //public IActionResult VeriAlmaBir(IFormCollection datas)
        //{
        //    var value1 = datas["txtValue1"];
        //    var value2 = datas["txtValue2"].ToString();
        //    var value3 = datas["txtValue3"];
        //    return View();
        //}

        //2. yontem, formdaki nameler ile ayni 
        //[HttpPost]
        //public IActionResult VeriAlmaBir(string txtValue1, string txtValue2, string txtValue3)
        //{
        //    return View();
        //}

        //3. yontem kullanicidan gelen veriler nesne,class gibi yapilarla yakalamak, yeni modeli form a gore yanimla orda veri sakla.
        [HttpPost]
        public IActionResult VeriAlmaBir(FormVeriOgrenme gelenveriler)
        {
            return View();
        }


        //Bind edilmis sekilde yollama
        [HttpPost]
        public IActionResult VeriAlmaBind(FormVeriOgrenme gelenveriler)
        {
            return View();
        }


        //QueryString icin ornek
        public IActionResult VeriAl(string a, string b)
        {
            var quaryString = Request.QueryString;
            // var a = Request.Query["a"].ToString(); //boylede alinabilir parametre yazilmaz ozaman actiona
            // var b = Request.Query["b"].ToString(); //ustte parametre yazilmasina gerek olmaz.
            return View(); //ustteki yontemler yerine direk model tanimlanadabilir querystringde tasinan veri ile ayni sekilde.
        }

        public IActionResult VeriAlRoute(string a, string b, string id)
        {
            var values = Request.RouteValues;
            return View();
        }


    }
}
