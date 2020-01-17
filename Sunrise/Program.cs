using System;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Simple.OData.Client.V3.Adapter;
using Nancy.Json;

namespace Sunrise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sunriseURL = "https://api.sunrise-sunset.org/json?lat=59.436962&lng=24.753574&date=today";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(sunriseURL);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response);
                Console.WriteLine(sunMode.Status);
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunrise}");
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunset}");
            }
        }
    }
}
