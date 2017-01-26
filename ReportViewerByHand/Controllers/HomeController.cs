using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReportViewerByHand.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        /// <summary>
        /// Call our aspx page to display the report here.
        /// </summary>
        /// <returns></returns>
        public ActionResult ServerReport()
        {
            return Redirect("../RepViewer/RepViewer.aspx?repLoc=remote");
        }

        /// <summary>
        /// Call our aspx page to display the report here.
        /// </summary>
        /// <returns></returns>
        public ActionResult LocalReport()
        {
            return Redirect("../RepViewer/RepViewer.aspx?repLoc=local");
        }
    }
}