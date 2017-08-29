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
    public class ProfileController : Controller
    {
        public IActionResult Index(int ID)
        {
            var robotList = RobotServices.Builder();
            return View(robotList.SingleOrDefault(w => w.ID == ID));
        } 
    } 
}