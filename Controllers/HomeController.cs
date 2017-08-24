using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using robots_dotnet.Models;
using robots_dotnet.Services;

namespace robots_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(robotList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
