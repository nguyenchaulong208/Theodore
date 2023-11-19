
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMvcXuanThuLab
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //Chuyen route sang First de test va hoc
                //Trong class FirstController co 1 controller tu tao la test()
                //Day la 1 phuong thuc tu dinnh nghia giong nhu trong console va cac mo hinh truoc day da hoc
                defaults: new { controller = "First", action = "Index", id = UrlParameter.Optional }
                
                
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "myroute",
                    defaults: new { controller = "Home", action = "Index" },
                    pattern: "{title}-{id}.html");
            });

        }
    }
}
