using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackerLibrary
{
	public class Time : IComparable<Time>, IEquatable<Time>
	{
		private int hourValue = 0;  // 24 time
		private int minuteValue = 0;

		public int Hour
		{
			get
			{
				return hourValue;
			}
			set
			{
				if (value > 23) throw new ArgumentException("Cannot set hour to be above 23");
				if (value < 0) throw new ArgumentException("Cannot set hour to be negative");
				hourValue = value;
			}
		}
		public int Minute
		{
			get
			{
				return minuteValue;
			}
			set
			{
				if (value > 59) throw new ArgumentException("Cannot set minute to be above 59");
				if (value < 0) throw new ArgumentException("Cannot set minute to be negative");
				minuteValue = value;
			}
		}

		public Time()
		{

		}

		public Time(int hour, int minute)
		{
			SetTime(hour, minute);
		}

		public void SetTime(int h, int m)
		{
			Hour = h;
			Minute = m;
		}

		public int GetMinutes()
		{
			return Hour * 60 + Minute;
		}

		public int CompareTo(Time other)
		{
			return GetMinutes() - other.GetMinutes();
		}

		public override int GetHashCode()
		{
			return GetMinutes();
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj is Time time) return Equals(time);
			return false;
		}

		public bool Equals(Time other)
		{
			if (other is null) return false;
			return other.GetMinutes() == GetMinutes();
		}

		#region Operators
		public static bool operator ==(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			return time1.Equals(time2);
		}

		public static bool operator !=(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			return !time1.Equals(time2);
		}

		public static bool operator >=(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			int value = time1.CompareTo(time2);
			return value == 0 || value > 0;
		}

		public static bool operator <=(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			int value = time1.CompareTo(time2);
			return value == 0 || value < 0;
		}

		public static bool operator >(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			int value = time1.CompareTo(time2);
			return value > 0;
		}

		public static bool operator <(Time time1, Time time2)
		{
			if (time1 is null || time2 is null) return false;
			int value = time1.CompareTo(time2);
			return value < 0;
		}
		#endregion
	}
}
