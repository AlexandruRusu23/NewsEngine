using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using WorldOfNews.Models;
using WorldOfNews.Roles;

namespace WorldOfNews
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Database.SetInitializer(new ArticleDatabaseInitializer());

            RoleActions roleActions = new RoleActions();
            roleActions.AddUserAndRole("Admin23", "canAdmin@gmail.com", "Pa$$word1", "roleAdmin");
            roleActions.AddUserAndRole("Editor23", "canEdit@gmail.com", "Pa$$word1", "roleEditor");
            roleActions.AddUserAndRole("User23", "user23@gmail.com", "Pa$$word1", "roleRegistered");
        }
    }
}