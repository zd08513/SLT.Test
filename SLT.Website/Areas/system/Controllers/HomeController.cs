using SLT.Website.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLT.Website.Areas.system.Controllers
{
    public class HomeController : Controller
    {
        [LoginActionFilter]
        public ActionResult Index()
        {
            return View();
        }

    }
}
