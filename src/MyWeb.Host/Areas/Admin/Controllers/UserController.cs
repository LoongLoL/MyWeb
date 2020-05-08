using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Repository;
using MyWeb.Repository.Repositorys;

namespace MyWeb.Host.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}