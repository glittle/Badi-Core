using System;

namespace System.Globalization
{
    public class BadiCalendar : Calendar
    {
        public override CalendarAlgorithmType AlgorithmType => base.AlgorithmType;

        public override int[] Eras => throw new NotImplementedException();

        public override DateTime MaxSupportedDateTime => base.MaxSupportedDateTime;

        public override DateTime MinSupportedDateTime => base.MinSupportedDateTime;

        public override int TwoDigitYearMax { get => base.TwoDigitYearMax; set => base.TwoDigitYearMax = value; }

        protected override int DaysInYearBeforeMinSupportedYear => base.DaysInYearBeforeMinSupportedYear;

        public override DateTime AddDays(DateTime time, int days)
        {
            return base.AddDays(time, days);
        }

        public override DateTime AddHours(DateTime time, int hours)
        {
            return base.AddHours(time, hours);
        }

        public override DateTime AddMilliseconds(DateTime time, double milliseconds)
        {
            return base.AddMilliseconds(time, milliseconds);
        }

        public override DateTime AddMinutes(DateTime time, int minutes)
        {
            return base.AddMinutes(time, minutes);
        }

        public override DateTime AddMonths(DateTime time, int months)
        {
            throw new NotImplementedException();
        }

        public override DateTime AddSeconds(DateTime time, int seconds)
        {
            return base.AddSeconds(time, seconds);
        }

        public override DateTime AddWeeks(DateTime time, int weeks)
        {
            return base.AddWeeks(time, weeks);
        }

        public override DateTime AddYears(DateTime time, int years)
        {
            throw new NotImplementedException();
        }

        public override object Clone()
        {
            return base.Clone();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetDayOfMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override DayOfWeek GetDayOfWeek(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDayOfYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInMonth(int year, int month)
        {
            return base.GetDaysInMonth(year, month);
        }

        public override int GetDaysInMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetDaysInYear(int year)
        {
            return base.GetDaysInYear(year);
        }

        public override int GetDaysInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetEra(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override int GetHour(DateTime time)
        {
            return base.GetHour(time);
        }

        public override int GetLeapMonth(int year)
        {
            return base.GetLeapMonth(year);
        }

        public override int GetLeapMonth(int year, int era)
        {
            return base.GetLeapMonth(year, era);
        }

        public override double GetMilliseconds(DateTime time)
        {
            return base.GetMilliseconds(time);
        }

        public override int GetMinute(DateTime time)
        {
            return base.GetMinute(time);
        }

        public override int GetMonth(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override int GetMonthsInYear(int year)
        {
            return base.GetMonthsInYear(year);
        }

        public override int GetMonthsInYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override int GetSecond(DateTime time)
        {
            return base.GetSecond(time);
        }

        public override int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
        {
            return base.GetWeekOfYear(time, rule, firstDayOfWeek);
        }

        public override int GetYear(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapDay(int year, int month, int day)
        {
            return base.IsLeapDay(year, month, day);
        }

        public override bool IsLeapDay(int year, int month, int day, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapMonth(int year, int month)
        {
            return base.IsLeapMonth(year, month);
        }

        public override bool IsLeapMonth(int year, int month, int era)
        {
            throw new NotImplementedException();
        }

        public override bool IsLeapYear(int year)
        {
            return base.IsLeapYear(year);
        }

        public override bool IsLeapYear(int year, int era)
        {
            throw new NotImplementedException();
        }

        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
        {
            return base.ToDateTime(year, month, day, hour, minute, second, millisecond);
        }

        public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(int kulliShay, int vahid, int year, int month, int day)
        {
            throw new NotImplementedException();
        }

        public override int ToFourDigitYear(int year)
        {
            return base.ToFourDigitYear(year);
        }

        public void ToBadiDate(DateTime time, out int kulliShay, out int vahid, out int year, out int month, out int day) {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
