﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weixin.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
              
            return View();
        }

        public ActionResult About()
        { 
            return View();
        }

        public ActionResult Contact()
        {  
            return View();
        }
    }
}
