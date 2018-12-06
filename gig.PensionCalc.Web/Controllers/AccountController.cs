using gig.PensionCalc.Web.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gig.PensionCalc.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User model)
        {
            return View();

        }

        [HttpPost]
        public ActionResult Logoff(User model)
        {
            return View();
        }
    }
}