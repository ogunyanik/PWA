using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace PWA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult DenemeApi()
        {
            Response res = new Response();
            res.StatusCode = HttpStatusCode.OK;
            res.Deneme = "ooo";
            return Json(res);
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

    public class Response : HttpResponseMessage
    {
        public string Deneme { get; set; } = "Selam";
    }
}