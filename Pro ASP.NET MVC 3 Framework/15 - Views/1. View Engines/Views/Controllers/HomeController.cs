﻿using System;
using System.Web.Mvc;

namespace Views.Controllers {
    public class HomeController : Controller {
        
        public ActionResult Index() {

            ViewData["Message"] = "Hello, World";
            ViewData["Time"] = DateTime.Now.ToShortTimeString();

            return View("No_Such_View");
        }
    }
}
