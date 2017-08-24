using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using robots_dotnet.Models;

namespace robots_dotnet.Models
{
    public class RobotModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string Phone { get; set; }
        public Dictionary<string, string> Address { get; set; } = new Dictionary<string, string>();

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