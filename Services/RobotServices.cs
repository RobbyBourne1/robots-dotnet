using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using robots_dotnet.Models;

namespace robots_dotnet.Services
{
    public class RobotServices
    {
        public static List<RobotModel> Builder()
        {
            // JsonSerializer serializer = new JsonSerializer();
            var robotList = new List<RobotModel>();

            using (var reader = new StreamReader(System.IO.File.Open("robotsData.Json", FileMode.Open)))
            {
                var robotReader = JsonConvert.DeserializeObject<List<RobotModel>>(reader.ReadToEnd());
                // var data = user.Split(',');
                Console.WriteLine(robotReader.First().Name);

                return robotReader;
            } 
        }
    }
}