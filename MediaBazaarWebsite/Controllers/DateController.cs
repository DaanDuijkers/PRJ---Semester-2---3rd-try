using MediaBazaarClassLibrary;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public class DateController
    {
        public DateTime Date { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }
        public DateTime WeekStart { get; set; }
        public DateTime WeekFinal { get; set; }

        public DateController() { }

        public DateController (DateTime date)
        {
            this.Date = date;
            this.Year = date.Year;
            this.Month = date.Month;
            this.Day = date.Day;

            DayOfWeek dayOfWeek = date.DayOfWeek;
            int days = dayOfWeek - DayOfWeek.Monday;
            this.WeekStart = date.AddDays(-days);
            this.WeekFinal = this.WeekStart.AddDays(4);
        }

        public void AddDay()
        {
            this.WeekStart = this.WeekStart.AddDays(1);
            this.Date = this.Date.AddDays(1);
        }
    }
}