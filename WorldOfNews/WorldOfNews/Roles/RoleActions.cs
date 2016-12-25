using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldOfNews.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WorldOfNews.Roles
{
    internal class RoleActions
    {
        internal void AddUserAndRole(string username, string email, string password, string role)
        {
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>(context);

            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists(role))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = role });
            }

            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = username,
                Email = email
            };
            IdUserResult = userMgr.Create(appUser, password);

            if (!userMgr.IsInRole(userMgr.FindByEmail(email).Id, role))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail(email).Id, role);
            }
        }
    }
}