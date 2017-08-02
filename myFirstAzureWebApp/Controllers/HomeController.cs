using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("Index() called.");
            return View();
        }

        public ActionResult About()
        {
            Trace.TraceWarning("About() called.");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            Trace.TraceError("Contact() called.");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}