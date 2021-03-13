using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.userName = newUser.UserName;
                return View("Index");
            }
            else
            {
                ViewBag.rejectedUser = newUser;
                ViewBag.error = "Passwords should match";
                return View("Add");
            }
        }
    }
}
