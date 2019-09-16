using System;
using System.Collections.Generic;

namespace JobTrackerLibrary
{
	public static class LogFilter
	{
		public static int? Year = null;
		public static int? Month = null;
		public static int? Day = null;

		public static List<Log> FilterLogs(Job job)
		{
			return job.FindAll(Filter);
		}

		public static void SetDate(int? year, int? month, int? day)
		{
			Year = year;
			Month = month;
			Day = day;
		}

		private static bool Filter(Log log)
		{
			bool year = true;
			bool month = true;
			bool day = true;
			if (Year != null) year = log.Date.Year == Year;
			if (Month != null) month = log.Date.Month == Month;
			if (Day != null) day = log.Date.Day == Day;
			return year && month && day;
		}
	}
}
