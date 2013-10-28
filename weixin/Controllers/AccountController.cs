using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using weixin.Filters;
using weixin.Models;

namespace weixin.Controllers
{
    
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult register()
        {
            return View();
        }

        public ActionResult getpwd()
        {
            return View();
        }
    }
}
