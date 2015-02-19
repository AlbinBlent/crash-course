using System;
using System.Collections.Generic;
using FFCG.CrashCourse.Data;
using FFCG.CrashCourse.Domain;
using NUnit.Framework;

namespace FFCG.CrashCourse.Test
{
    [TestFixture]
    public class Runner
    {
        [Test]
        public void SomeTest()
        {
            var fetcher = new SmhiWeatherDataFetcher();
            var months = fetcher.GetLatestThreeMonths();
        }
    }
}
