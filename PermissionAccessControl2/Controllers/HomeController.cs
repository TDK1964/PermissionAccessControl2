﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PermissionAccessControl2.Models;
using ServiceLayer.UserServices;
using ServiceLayer.UserServices.Concrete;

namespace PermissionAccessControl2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] IListUsersService service)
        {
            return View(service.ListUserWithRolesAndDataTenant());
        }

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
