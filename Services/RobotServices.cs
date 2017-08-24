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
        public List<RobotModel> Builder()
        {
            JsonSerializer serializer = new JsonSerializer();
            var robotList = new List<RobotModel>();

            using (var reader = new StreamReader(System.IO.File.Open("robotsData.Json", FileMode.Open)))
            using (var jsonReader = new JsonTextReader(reader))
                while (reader.Peek() >= 0)
                {
                    var robotReader = JsonConvert.DeserializeObject<RobotModel>(reader.ReadToEnd());
                    // var data = user.Split(',');
                    robotList.Add(robotReader);
                }
            return robotList;
        }
    }
}