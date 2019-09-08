using System;

namespace JobTrackerLibrary
{
	public class Log : IComparable<Log>, IEquatable<Log>
	{
		private DateTime dateValue = new DateTime();
		private Time startValue = new Time(0, 0);
		private Time endValue = new Time(23, 59);
		public string Remark = "";

		public DateTime Date
		{
			get { return dateValue; }
			set
			{
				dateValue = new DateTime(value.Year, value.Month, value.Day);
			}
		}

		public Time Start
		{
			get { return startValue; }
			set
			{
				ThrowTimeExceptions(value, End);
				startValue = value;
			}
		}

		public Time End
		{
			get { return endValue; }
			set
			{
				ThrowTimeExceptions(Start, value);
				endValue = value;
			}
		}

		public Log()
		{

		}

		public Log(int y, int m, int d, Time start, Time end)
		{
			SetDate(y, m, d);
			SetShift(start, end);
		}

		public Log(DateTime _date, Time start, Time end)
		{
			Date = _date;
			SetShift(start, end);
		}

		public void SetDate(int year, int month, int day)
		{
			Date = new DateTime(year, month, day);
		}

		public void SetShift(Time start, Time end) // This has to use backing values, otherwise exceptions
		{
			ThrowTimeExceptions(start, end);
			startValue = start;
			endValue = end;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj is Log log) return Equals(log);
			return false;
		}

		public bool Equals(Log log)
		{
			if (log == null) return false;
			return Date.Year == log.Date.Year && Date.Month == log.Date.Month && Date.Day == log.Date.Day && Start == log.Start && End == log.End;
		}

		public override int GetHashCode()
		{
			return Date.GetHashCode() ^ Start.GetHashCode() ^ End.GetHashCode();
		}

		public static void ThrowTimeExceptions(Time start, Time end)
		{
			if (StartTimeHigherThanEndTimeException(start, end))
				throw new ArgumentException("Starting time can't be higher than ending time");
			if (StartingTimeSameAsEndingTimeException(start, end))
				throw new ArgumentException("Starting time can't be the same as the ending time");
		}

		public static bool StartTimeHigherThanEndTimeException(Time start, Time end)
		{
			return start.Hour > end.Hour || (start.Hour == end.Hour && start.Minute > end.Minute);
		}

		public static bool StartingTimeSameAsEndingTimeException(Time start, Time end)
		{
			return start.Hour == end.Hour && start.Minute == end.Minute;
		}

		public DateTime TimeToDateTime(Time time)
		{
			return new DateTime(Date.Year, Date.Month, Date.Day, time.Hour, time.Minute, 0, 0);
		}

		public int CompareTo(Log other)
		{
			DateTime thisDate = TimeToDateTime(Start);
			DateTime otherDate = other.TimeToDateTime(other.Start);

			return thisDate.CompareTo(otherDate);
		}
		public double GetEstimatedDuration() // Returns duration in hours
		{
			int startMinutes = Start.Hour * 60 + Start.Minute;
			int endMinutes = End.Hour * 60 + End.Minute;
			int minutes = Math.Abs(endMinutes - startMinutes);
			int minMinutes = minutes / 15 * 15;
			int maxMinutes = minutes / 15 * 15 + 15;
			int closest = minutes - minMinutes > maxMinutes - minutes ? maxMinutes : minMinutes;
			return closest / 60.0;
		}
	}
}
