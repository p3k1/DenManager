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
            return View(context.Beers.ToList());
        }

        [Authorize]
        public ActionResult Vodka()
        {
            return View(context.Products.ToList());
        }

        [Authorize]
        public ActionResult Cigarettes()
        {
            return View(context.Cigarettes.ToList());
        }

        [Authorize]
        public ActionResult Debtors()
        {
            return View(context.Debters.ToList());
        }
    }

}
