using System.Web;
using System.Web.Mvc;

namespace assignment9_MVC_HotDog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
