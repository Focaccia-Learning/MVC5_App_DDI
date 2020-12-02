using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_App_DDI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region 5.3調整 Default Route
            routes.MapRoute(
                name: "Test",  // 1.名稱必須是唯一
                url: "{action}/{id}", //2.範例可移除掉{controller}
                defaults: new
                {
                    controller = "Home",//3.網址移除掉{controller}就必須吃預設值
                    action = "Index",
                    id = UrlParameter.Optional
                },
                constraints: new
                {
                    action = "(About|Contact)"// 4.限制只有 About & Contact 這個Action 會被比對到 (利用Regix語法同時允許 About & Contact )
                },
                namespaces: new[] { "MVC5_App_DDI.Controllers" }//5.也可以限制Namespace 必須相同才通過
                );
            #endregion


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
