using MVCBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBiblioteka.Controllers
{
    public class RolesController : Controller
    {
        public string Create()
        {
            IdentityManager im = new IdentityManager();

            im.CreateRole("Administrator");
            im.CreateRole("Czytelnik");
            im.CreateRole("Pracownik");

            im.DeleteRole("Admin");
            im.DeleteRole("User");

            return "ok";
        }

        public string AddToRole()
        {
            IdentityManager im = new IdentityManager();

            im.AddUserToRoleByUsername("j.kowalski@gmail.com", "Admin");
            im.AddUserToRoleByUsername("a.nowak@gmail.com", "User");

            return "OK";
        }
    }
}