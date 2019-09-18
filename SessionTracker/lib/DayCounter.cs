using System;

namespace SessionTracker.lib
{
    public class DayCounter
    {
        private DateTime _date;
        public DateTime Date { get { return _date; } }
        public double Counter { get; set; }
        public int Year { get { return _date.Year; } }
        public int Month { get { return _date.Month; } }
        public int Day { get { return _date.Day; } }
        public int Week { get; set; }
        public string DayName { get { return getDay(); } }
        private int _weekDay = 1;

        public Status status{ get{ return getStatus(); } }

        private Status getStatus()
        {
            if (Counter / 60 > 10) return Status.Critical;
            if (Counter / 60 > 7.6) return Status.Warn;
            if (Counter / 60 < 6) return Status.Low;
            return Status.Normal;
        }

        private string getDay()
        {
            switch (_weekDay) {
                case 0: return "Sonntag";
                case 1: return "Montag";
                case 2: return "Dienstag";
                case 3: return "Mittwoch";
                case 4: return "Donnerstag";
                case 5: return "Freitag";
                case 6: return "Sonnabend";
                default: return "SanktNimmerlein";
            }
        }

        public DayCounter() {
        }

        public DayCounter(DateTime Date, int WeekDay, int Week, double Counter) {
            this.Counter = Counter;
            this._weekDay = WeekDay;
            this.Week = Week;
            this._date = Date;
        }
    }
}