using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssessForm.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}