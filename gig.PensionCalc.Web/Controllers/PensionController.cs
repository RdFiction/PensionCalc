using Gig.PensionCalc.Business;
using Gig.PensionCalc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gig.PensionCalc.Web.Controllers
{
    public class PensionController : Controller
    {
        // GET: Pension
        public ActionResult Index()
        {
            //HttpContext.Request.Form
            //HttpContext.Request.QueryString
            //HttpContext.Request.Cookies
            //HttpContext.Request.Files
            //HttpContext.Request.Params;

            return View();
        }
        [HttpPost]
        public ActionResult Index( UserInfoModel info)
        {
            var result = new PensionInfo();

            if (!ModelState.IsValid)
            {
                return View("Index", info);  
            }

            if (info.BirthDay < new System.DateTime(1900, 01, 01))
            {
                ModelState.AddModelError("BirthDay", "Да ну нафиг");
            }

            if (info.Sex == Sex.Unknown)
            {
                ModelState.AddModelError("", "Ты что вообще такое");
            }


            var user = new UserInfoModel
            {
                Name = info.Name,
                Sex = info.Sex,
                BirthDay = info.BirthDay,
                Work = info.Work

            };

            var calc = new Calculator();
            var pensionInfo = calc.Calc(user);

           

            return View(result);
        }
    }
   }