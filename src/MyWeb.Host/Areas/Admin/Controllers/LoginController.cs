using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Host.Areas.Admin.Controllers
{
    public class LoginController : AdminControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}