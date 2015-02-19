using System;
using System.Collections.Generic;
using System.Net;
using FFCG.CrashCourse.Domain;
using Newtonsoft.Json;

namespace FFCG.CrashCourse.Data
{
    public class SmhiWeatherDataFetcher : IWeatherDataFetcher
    {
        public List<DayObservation> GetLatestThreeMonths()
        {
            string url = "http://opendata-download-metobs.smhi.se/api/version/latest/parameter/5/station/98210/period/latest-months/data.json";

            var webClient = new WebClient();
            var downloadedString = webClient.DownloadString(url);

            var smhiReturnData = JsonConvert.DeserializeObject<SmhiReturnData>(downloadedString);

            var dayObservations = new List<DayObservation>();

            foreach (var item in smhiReturnData.Value)
            {
                dayObservations.Add(new DayObservation(item.Ref, item.Value));
            }

            return dayObservations;
        }
    }

    public class SmhiReturnData
    {
        public List<SmhiReturnDay> Value { get; set; } 
    }

    public class SmhiReturnDay
    {
        public DateTime Ref { get; set; }
        public double Value { get; set; }
    }
}