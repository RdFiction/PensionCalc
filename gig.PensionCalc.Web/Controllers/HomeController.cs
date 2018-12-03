using gig.PensionCalc.Web.Models;
using gig.PensionCalc.Web.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gig.PensionCalc.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            using (var tx = session.BeginTransaction())
            {
                var females = session
                    .Query<UserInfoModel>()
                    .Where(c => c.Name == "Вася")
                    .ToList();

                foreach (var cat in females)
                {
                    Console.Out.WriteLine("Female Cat: " + cat.Name);
                }

                tx.Commit();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}