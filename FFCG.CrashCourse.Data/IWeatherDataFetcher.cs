using System;
using FFCG.CrashCourse.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FFCG.CrashCourse.Data
{
    public interface IWeatherDataFetcher
    {
        List<DayObservation> GetLatestThreeMonths();
    }
}
