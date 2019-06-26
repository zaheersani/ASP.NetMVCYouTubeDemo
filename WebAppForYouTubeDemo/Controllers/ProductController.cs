using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppForYouTubeDemo.Models;

namespace WebAppForYouTubeDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<string> products = new List<string>();
            products.Add("Dell Laptop");
            products.Add("HP Laptop");
            products.Add("Printer");

            ViewBag.Prods = products;

            List<string> cList = new List<string>();
            cList.Add("John");
            cList.Add("Michael");
            cList.Add("Tom");

            ViewData["Customers"] = cList;

            return View();
        }

        public ActionResult Display()
        {
            Product product = new Product()
            {
                Name = "Laptop",
                Brand = "Dell",
                Price = 45000
            };
            return View(product);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            return View("Display", product);
        }
    }
}