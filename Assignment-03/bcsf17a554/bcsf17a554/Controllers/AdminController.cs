using bcsf17a554.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bcsf17a554.Controllers
{
    public class AdminController : Controller
    {
        methods m = new methods();
        public List<User> u = new List<User>();
        public List<Post> p = new List<Post>();
        //index functionality
        public IActionResult Index()
        {
            return View();
        }


        //about functionality
        public IActionResult about()
        {
            return View();
        }


        //create functionality
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Post post)
        {
            if (m.createpost(post))
            {
                return View();
            }
            ModelState.AddModelError(string.Empty, "not valid");
            return View();
        }

        //profile functionality
        public IActionResult profile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult profile(User user)
        {
            if(m.updateprofile(user))
            {
                return View();
            }
            ModelState.AddModelError(string.Empty, "not valid");
            return View();
        }


        //update functionality
        public IActionResult update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult update(Post post)
        {
            if (m.updatepost(post))
            {
                return View();
            }
            ModelState.AddModelError(string.Empty, "not valid");
            return View();
        }

    }
}
