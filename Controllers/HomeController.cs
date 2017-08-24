using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using robots_dotnet.Models;

namespace robots_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
             using (var reader = new StreamReader(System.IO.File.Open("robotsData.Json", FileMode.Open)))
             using (var jsonReader = new JsonTextReader(reader))
                while (reader.Peek() >= 0)
                {
                    var user = reader.ReadToEnd();
                    var data = user.Split(',');
                    for (int i = 0; i < data.Length - 5; i += 5);
                    
                }
            return null;
            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
