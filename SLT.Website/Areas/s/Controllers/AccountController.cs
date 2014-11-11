using SLT.BLL;
using SLT.Common;
using SLT.Entity;
using SLT.Website.Areas.s.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLT.Website.Areas.s.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AdminUserModel adminUserModel)
        {
            if (ModelState.IsValid)
            {
                BLLAdminUser bll = new BLLAdminUser();
                AdminUser obj = bll.Login(adminUserModel.UserAccount, Helper.Encrypt(adminUserModel.UserPwd));
                if (obj != null)
                {
                    Session["AdminUser"] = obj;
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("", "用户名或密码有误！");
                }
            }
            return View(adminUserModel);
        }

    }
}
