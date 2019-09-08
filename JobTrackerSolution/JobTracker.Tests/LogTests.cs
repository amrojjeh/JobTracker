using System;
using Xunit;

namespace JobTrackerLibrary.Tests
{
	public class LogTests
	{
		[Theory]
		[InlineData(5, 5, 5)]
		[InlineData(2006, 7, 1)]
		[InlineData(2019, 8, 1)]
		[InlineData(2019, 8, 31)]
		[InlineData(2000, 2, 29)] // A leap year
		public void SetDate_ShouldWork(int year, int month, int day)
		{
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));
			log.SetDate(year, month, day);
			Assert.Equal(year, log.Date.Year);
			Assert.Equal(month, log.Date.Month);
			Assert.Equal(day, log.Date.Day);
		}

		[Theory]
		[InlineData(-1, -1, -1)] // Just negatives
		[InlineData(int.MaxValue, int.MaxValue, int.MaxValue)] // Absurd values
		[InlineData(int.MinValue, int.MinValue, int.MinValue)] // More absurd values
		[InlineData(int.MaxValue, 12, 13)] // Absurd year
		[InlineData(2019, 12, 32)] // Akward day
		[InlineData(2002, 13, 12)] // Akward month
		[InlineData(2019, 2, 29)] // Not a leap year
		public void SetDate_Exceptions(int year, int month, int day)
		{
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));
			Assert.Throws<ArgumentOutOfRangeException>(() => log.SetDate(year, month, day));
		}

		[Theory]
		[InlineData(5, 5, 5)]
		[InlineData(2006, 7, 1)]
		[InlineData(2019, 8, 1)]
		[InlineData(2019, 8, 31)]
		[InlineData(2000, 2, 29)] // A leap year
		public void SetDate_ShouldWorkDateTime(int year, int month, int day)
		{
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));
			DateTime date = new DateTime(year, month, day);
			log.Date = date;
			Assert.Equal(year, log.Date.Year);
			Assert.Equal(month, log.Date.Month);
			Assert.Equal(day, log.Date.Day);
		}

		[Theory]
		[InlineData(00, 00, 23, 59)]
		[InlineData(15, 30, 16, 30)]
		[InlineData(15, 30, 16, 10)] // Minutes are lower, shouldn't throw
		public void SetShift_ShouldWork(int starth, int startm, int endh, int endm)
		{
			Time start = new Time(starth, startm);
			Time end = new Time(endh, endm);
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));

			log.SetShift(start, end);

			Assert.Equal(starth, log.Start.Hour);
			Assert.Equal(startm, log.Start.Minute);
			Assert.Equal(endh, log.End.Hour);
			Assert.Equal(endm, log.End.Minute);
		}

		[Theory]
		[InlineData(00, 00, 00, 00)]
		[InlineData(15, 30, 3, 2)]
		[InlineData(15, 30, 15, 20)]
		public void SetShift_ArgumentException(int starth, int startm, int endh, int endm)
		{
			Time start = new Time(starth, startm);
			Time end = new Time(endh, endm);
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));

			Assert.Throws<ArgumentException>(() => log.SetShift(start, end));
		}

		[Theory]
		[InlineData(00, 00, 23, 59, 24)]
		[InlineData(15, 30, 16, 30, 1)]
		[InlineData(15, 30, 16, 10, 0.75)]
		public void GetEstimatedDuration_ShouldWork(int starth, int startm, int endh, int endm, double expected)
		{
			Time start = new Time(starth, startm);
			Time end = new Time(endh, endm);
			Log log = new Log(1, 1, 1, new Time(4, 4), new Time(5, 5));

			log.SetShift(start, end);

			Assert.Equal(expected, log.GetEstimatedDuration());
		}

		[Theory]
		[InlineData(1, 1, 1, 00, 00, 00, 11, 1, 1, 1, 00, 20, 00, 23, false)] // Different minutes
		[InlineData(1, 1, 1, 15, 30, 16, 30, 1, 1, 1, 16, 30, 17, 30, false)] // Different hour
		[InlineData(1, 1, 2, 15, 30, 16, 30, 1, 1, 1, 15, 30, 16, 30, false)] // Different day
		[InlineData(1, 2, 1, 15, 30, 16, 30, 1, 1, 1, 15, 30, 16, 30, false)] // Different month
		[InlineData(2, 1, 1, 15, 30, 16, 30, 1, 1, 1, 15, 30, 16, 30, false)] // Different year
		[InlineData(1, 1, 1, 15, 30, 16, 30, 1, 1, 1, 15, 30, 16, 30, true)] // Same
		public void Equal_ShouldWork(int year, int month, int day, int starth, int startm, int endh, int endm,
									int year2, int month2, int day2, int start2h, int start2m, int end2h, int end2m,
									bool expected)
		{
			Time start = new Time(starth, startm);
			Time end = new Time(endh, endm);
			Log log = new Log(year, month, day, start, end);

			Time start2 = new Time(start2h, start2m);
			Time end2 = new Time(end2h, end2m);
			Log log2 = new Log(year2, month2, day2, start2, end2);
			if (expected) Assert.True(log.Equals(log2));
			else Assert.False(log.Equals(log2));
		}

		[Fact]
		public void CompareTo_Date()
		{
			Log log = new Log(2019, 9, 20, new Time(3, 15), new Time(4, 15));
			Log log2 = new Log(2019, 9, 19, new Time(3, 15), new Time(4, 15));

			// Log should be 'bigger' or 'later' than log2
			bool expected = true;
			bool actual = log.CompareTo(log2) > 0;
			Assert.Equal(actual, expected);
		}

		[Fact]
		public void CompareTo_Time()
		{
			Log log = new Log(2019, 9, 20, new Time(3, 15), new Time(4, 15));
			Log log2 = new Log(2019, 9, 20, new Time(2, 15), new Time(4, 15));

			// Log should be 'bigger' or 'later' than log2
			bool expected = true;
			bool actual = log.CompareTo(log2) > 0;
			Assert.Equal(actual, expected);
		}
	}
}
