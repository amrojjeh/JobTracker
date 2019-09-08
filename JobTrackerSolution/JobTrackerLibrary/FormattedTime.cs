using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackerLibrary
{
	public static class FormattedTime
	{
		public static string Get24Time(Time time)
		{
			return $"{time.Hour:D2}:{time.Minute:D2}";
		}

		public static string Get12Time(Time time)
		{
			int hour12 = time.Hour > 12 ? time.Hour - 12 : time.Hour;
			hour12 = time.Hour == 0 ? 12 : hour12; // Because 00:00 is 12 AM for some weird reason
			return $"{hour12:D2}:{time.Minute:D2} {(time.GetMinutes() >= 720 ? "PM" : "AM")}";
		}
	}
}
