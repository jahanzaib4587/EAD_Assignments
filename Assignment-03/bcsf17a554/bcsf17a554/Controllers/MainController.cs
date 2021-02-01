using bcsf17a554.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcsf17a554.Controllers
{
    public class MainController : Controller
    {
        methods m = new methods();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(User user)
        {
            if(m.asadmin(user))
            {
                return View("~/Admin/Index");
            }
            else if(m.asuser(user))
            {
                return View("~/Users/Index");
            }
            return View();
        }
        public IActionResult signUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signUp(User user)
        {
            if(m.adduser(user))
            {
                return View("login");
            }
            return View();
        }
    }
}
