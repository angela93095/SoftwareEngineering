﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            User model = new User();
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            return View(model);
        }

        public ActionResult Forum()
        {
            forum model = new forum();
            return View(model);
        }

        [HttpPost]
        public ActionResult Forum(forum model)
        {
            return View(model);
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