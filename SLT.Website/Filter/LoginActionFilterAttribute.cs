/*=====================================================
 * 创 建 人：周东
 * 创建时间：2014/11/10 16:49:52
 * 描述说明：
 * 修 改 人：
 * 修改时间：
 * 修改备注：
 * @version 1.0
 *======================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SLT.Website.Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class LoginActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["AdminUser"] == null)
            {
                string url = filterContext.RequestContext.HttpContext.Request.Url.Authority.ToString();
                filterContext.HttpContext.Response.Redirect(string.Format("http://{0}/s/account/login",url));
            }
        }
    }
}