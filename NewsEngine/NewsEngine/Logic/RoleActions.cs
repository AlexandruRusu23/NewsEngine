using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsEngine.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NewsEngine.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            // Access the application context and create result variables
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(context);

            // A Role Manager
            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if(!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "canEditUser@newsengine.com",
                Email = "canEditUser@newengine.com"
            };
            IdUserResult = userMgr.Create(appUser, "Pa$$word1");

            if(!userMgr.IsInRole(userMgr.FindByEmail("canEditUser@newengine.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("canEditUser@newengine.com").Id, "canEdit");
            }
        }
    }
}