using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ApplicationEvents
{
    public class Global : HttpApplication
    {
       protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["TotalApplication"] = 0;
            Application["TotalUserSessions"] = 0;
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;


        }

        protected void Sess
    }
}