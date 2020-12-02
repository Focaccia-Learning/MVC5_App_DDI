using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC5_App_DDI.Helpers
{
    public static class CruuentControllerName
    {
        public static string GetCruuentControllerName(this HtmlHelper helper)
        {
            return (string)helper.ViewContext.RouteData.Values["Controller"];
        }
    }
}
