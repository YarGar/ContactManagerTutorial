using System.Web;
using System.Web.Mvc;

namespace ContactManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //THESE FILTERS ADD A GLOBAL LOGIN REQUIREMENT. 
            //ONLY CONTROLLERS ANNOTATED WITH "AllowAnonymous" WILL ALLOW ANONYMOUS USERS TO ACCESS THEM.
            filters.Add(new System.Web.Mvc.AuthorizeAttribute());
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
