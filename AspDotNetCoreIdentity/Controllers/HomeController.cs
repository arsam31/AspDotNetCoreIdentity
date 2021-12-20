using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;

namespace AspDotNetCoreIdentity.Controllers
{

    public class HomeController : Controller
    {
        //[Authorize(Policy = "OnlyAdminandHRAccess")]
        public readonly int  arsam=1;
        public HomeController()
        {

            var a = ++arsam;
            var b = arsam++;
        }
        public IActionResult Index()
        {

      

            return View();
        }
      
        [Authorize(Roles = "HR")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
