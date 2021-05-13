using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica.EF.Logic;

namespace Practica.EF.MVC.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            CountryLogic logic = new CountryLogic();

            return View(logic.GetPaises());
        }
    }
}