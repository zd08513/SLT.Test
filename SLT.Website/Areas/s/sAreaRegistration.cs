using System.Web.Mvc;

namespace SLT.Website.Areas.s
{
    public class sAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "s";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "s_default",
                "s/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
