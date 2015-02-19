using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FFCG.CrashCourse.Data;
using FFCG.CrashCourse.Domain;
using FFCG.CrashCourse.Web.Models;

namespace FFCG.CrashCourse.Web.Controllers
{
    public class ObservationsController : Controller
    {
        // GET: Observations
        public ActionResult Index()
        {
            //Todo: Returnera en lista av alla observationer

            var fetcher = new SmhiWeatherDataFetcher();
            List<DayObservation> observations = fetcher.GetLatestThreeMonths();
            
            var viewModels = new List<ObservationViewModel>();

            foreach (var observation in observations)
            {
                viewModels.Add(new ObservationViewModel
                {
                    Date = observation.Date,
                    Value = observation.Value
                });
            }
            
            return View(viewModels);
        }

        public ActionResult Day()
        {
            //Todo: Visa en specifik dag
            return View();
        }
    }
}