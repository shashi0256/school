using System.Web.Mvc;

namespace School.Areas.Menu2A
{
    public class Menu2AAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Menu2A";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Menu2A_default",
                "Menu2A/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}