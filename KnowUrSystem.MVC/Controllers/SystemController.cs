
using KnowUrSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowUrSystem.MVC.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TradeDistribution()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TradeDistribution(DistributionRawData model)
        {
            return View();
        }
    }
}