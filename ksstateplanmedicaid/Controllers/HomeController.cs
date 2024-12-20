using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSStatePlanMedicaidPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("UnderConstruction")]
        public ActionResult UnderConstruction()
        {
            return View();
        }

        [Route("UnderConstructionTop")]
        public ActionResult UnderConstructionTop()
        {
            return View();
        }
        [Route("Top")]
        public ActionResult Top()
        {
            return View();
        }
        [Route("Amendments")]
        public ActionResult Amendments()
        {
            return View();
        }
        [Route("AmendmentsTop")]
        public ActionResult AmendmentsTop()
        {
            return View();
        }
        [Route("AmendmentsWIP")]
        public ActionResult AmendmentsWIP()
        {
            return View();
        }
        [Route("AmendmentsTopWIP")]
        public ActionResult AmendmentsTopWIP()
        {
            return View();
        }
    }
}