using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_APP.Filters
{
    public class LogFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);


        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);

        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);

        }

        private void Trace(string methodName, RouteData routeData)
        {
            var actonName = routeData.Values["Action"].ToString();
            var controllerName = routeData.Values["Controller"].ToString();

            HttpContext.Current.Response.Write($"MethodName={methodName}, Controller={controllerName}, Action={actonName}<hr>");
        }
    }
}