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
    public class HomeController : Controller
    {
        [LoginActionFilter]
        public ActionResult Index()
        {
            BLLAdminMenu bll = new BLLAdminMenu();
            ViewBag.MenuList = bll.GetList();
            List<AdminMenu> list=bll.GetList();
            return View();
        }

    }
}
