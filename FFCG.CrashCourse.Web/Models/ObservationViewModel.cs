using System;
using System.ComponentModel;

namespace FFCG.CrashCourse.Web.Models
{
    public class ObservationViewModel
    {
        [DisplayName("Datum")]
        public DateTime Date { get; set; }

        [DisplayName("Nederbörd")]
        public double Value { get; set; }
    }
}