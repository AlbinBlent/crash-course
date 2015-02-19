using System;
using System.ComponentModel;

namespace FFCG.CrashCourse.Domain
{
    public class DayObservation
    {
        private readonly DateTime _date;
        private readonly double _value;

        public DateTime Date
        {
            get { return _date; }
        }

        public double Value
        {
            get { return _value; }
        }

        public DayObservation(DateTime date, double value)
        {
            _date = date;
            _value = value;
        }
    }
}
