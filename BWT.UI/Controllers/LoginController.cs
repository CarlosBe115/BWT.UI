using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWT.UI.Controllers
{
    public class LoginController : Controller
    {
        public static string Usertoken { get; private set; }

        public IActionResult Login()
        {
            
            //HttpContext.Session.SetString(Usertoken, "12345");
            //HttpContext.Session.GetString(Usertoken);
            return View();
        }
    }
}