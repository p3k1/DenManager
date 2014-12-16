using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DenManager.DAL;

namespace DenManager.Controllers
{
    public class DenController : Controller
    {
        private ProductsContext context = new ProductsContext();

        [Authorize]
        public ActionResult Index()
        {
            return View("Cocpit");
        }

        [Authorize]
        public ActionResult Beers()
        {
            return View(context.Products.ToList());
        }
    }
}
