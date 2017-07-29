using BMart.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMart.com.Controllers
{
    public class WallmartController : Controller
    {
        // GET: Wallmart
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            var products = new Product();

            return Json(products.GetProducts(), JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            var data = new Product();
            var products = data.GetProducts();
            products.Add(product);

            return Json(products);
        }

        public ActionResult WalMartProducts(string query)
        {
            if (!String.IsNullOrEmpty(query))
            {
                var service = new ExternalProductService();
                var result = service.GetWalmartProducts(query);
                return View(result);
            }
            else
            {
                return View(new WalmartInfo());
            }
            

        }
    }
}