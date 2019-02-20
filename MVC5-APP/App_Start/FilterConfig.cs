using MVC5_APP.Filters;
using System.Web;
using System.Web.Mvc;

namespace MVC5_APP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogFilterAttribute());
        }
    }
}
