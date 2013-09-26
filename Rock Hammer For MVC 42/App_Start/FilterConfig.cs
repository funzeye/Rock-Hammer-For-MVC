using System.Web;
using System.Web.Mvc;

namespace Rock_Hammer_For_MVC_42
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}