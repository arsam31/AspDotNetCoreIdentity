using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreIdentity.Controllers
{
    public class UnauthorisedController : Controller
    {// GET: Unauthorised
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            //Microsoft.AspNetCore.Session.Abandon();
            return View();
        }
    }
}