using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using zeroToHeroMVC.Models;
using zeroToHeroMVC.Models.ViewModels;

using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace zeroToHeroMVC.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult GetProducts()
        {
            JsonResult result = Json(new Product
            {
                Id = 5,
                ProductName = "Terlik",
                Quantity = 15
            });

            Product product = new Product
            {
                Id = 1,
                ProductName = "Aa product",
                Quantity = 11
            };

            User user = new User
            {
                Id = 1,
                Name = "can",
                LastName = "ozdemir"
            };
            Customers customers = new Customers
            {
                Id = 4,
                CustomerName = "alper",
                CustomerLastName = "cubukcu"
            };
            ////view model ornegi
            //UserProduct userProduct = new UserProduct
            //{
            //    User = user,
            //    Product = product
            //};
            //return View(userProduct);


            //Tuple nesnesi ornegi.
            var userProductTuple = (product, user, customers);
            return View(userProductTuple);
        }

        public ActionResult Deneme()
        {
            XXX();
            return View();
        }

        [NonAction]
        public void XXX()
        {

        }

        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product{ Id=1, ProductName="A product", Quantity = 10 },
                new Product{ Id=2, ProductName="B product", Quantity = 15 },
                new Product{ Id=3, ProductName="C product", Quantity = 20 },
            };

            #region Model Bazli Veri Gonderimi
            //return View(products);
            #endregion

            #region Veri Tasima Kontrolleri

            #region ViewBag
            //ViewBag.products = products;
            #endregion

            #region ViewData
            ViewData["products"] = products;
            #endregion

            string data = JsonSerializer.Serialize(products); //TempData icin serilize eder nesneyi.

            #region TempData
            TempData["products"] = data;
            #endregion
            #endregion
            return RedirectToAction("JsonSerilizDeneme");
        }

        public IActionResult Index3()
        {
            ViewBag.deneme = 10;
            ViewData["denemeViewData"] = 15;
            TempData["denemeTemp"] = 20;
            return RedirectToAction("Index2");
            //return View();
        }

        public IActionResult Index2()
        {
            var v1 = ViewBag.deneme;
            var v2 = ViewData["denemeViewData"];
            var v3 = TempData["denemeTemp"];
            return View();
        }

        public IActionResult JsonSerilizDeneme()
        {
            var data = TempData["products"].ToString(); //serilize edilen datayi aldik. Ama string olarak.
            List<Product> denemeTempYollama = JsonSerializer.Deserialize<List<Product>>(data);     //deserilize ettik.
            return View();
        }

        public IActionResult FormHelper()
        {
            return View();
        }

        public IActionResult modelBindView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult modelBindView(Product product)
        {
            return View();
        }

        //Model bind ile veri yollama
        [HttpPost]
        public IActionResult modelBindViewModel(Product product)
        {
            return View();
        }


        //ajax ile veri yollama ögrenimi için view
        public IActionResult ajaxLearn()
        {
            var tuple = (new Product(), new User()); //tuple ile veri almadan once o nesneler null donmesin diye conrollerda yaratilmali.
            return View(tuple);
        }

        //ajax ile veri almak için post actionu
        [HttpPost]
        public IActionResult ajaxLearn(Product product)
        {
            return View();
        }

        //tuple ile veri alma 
        [HttpPost]
        public IActionResult tuplePost([Bind(Prefix = "item1")]Product product, [Bind(Prefix = "item2")]User user)
        {
            return RedirectToAction("ajaxLearn");
        }

        public IActionResult validationLearning()
        {
            return View();
        }

        [HttpPost]
        public IActionResult validationLearning(Product product)
        {
            //ModelState : MVC`de bir type in data annotationlarinin durumunu kontrol eden ve geriye sonuc donen bir property.
            //model state ile check edilicek classtaki required kisimlari.
            if (!ModelState.IsValid)
            {
                // Error dondurmek icin kullaniyorsun burayi, veya loglama islemleri icin.
                ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == ModelValidationState.Invalid).Errors[0].ErrorMessage;
                return View(product);
            }
            // islem veya operasyon artik burda gerceklestirilir.
            return View();
        }
    }
}
