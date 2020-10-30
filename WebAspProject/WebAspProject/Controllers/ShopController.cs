using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAspProject.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult shopCategory()
        {
            return View();
        }
        public ActionResult productDetails()
        {
            return View();
        }

        public ActionResult compareList()
        {
            return View();
        }

    }
}