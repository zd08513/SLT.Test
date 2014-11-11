using DevNet.Common;
using SLT.BLL;
using SLT.Entity;
using SLT.Website.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLT.Website.Areas.s.Controllers
{
    [LoginActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BLLAdminMenu bll = new BLLAdminMenu();
            ViewBag.MenuList = bll.GetList();
            return View();
        }

    }
}
