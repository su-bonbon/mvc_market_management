﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World from Action Mothod.";
        }

        public string Error()
        {
            return "I have an Error here.";
        }
    }
}
