using System.Web;
using System.Web.Mvc;

namespace GymBase_MVC_ProjectDBS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
