﻿using Microsoft.AspNetCore.Mvc;

namespace ePizzaHub.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
