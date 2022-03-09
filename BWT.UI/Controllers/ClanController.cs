using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWT.UI.Controllers
{
    public class ClanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
