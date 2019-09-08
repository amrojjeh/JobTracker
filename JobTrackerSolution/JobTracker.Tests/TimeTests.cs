using System;
using Xunit;

namespace JobTrackerLibrary.Tests
{
	public class TimeTests
	{
		[Theory]
		[InlineData(1, 2)]
		[InlineData(15, 30)]
		[InlineData(23, 59)]
		[InlineData(0, 0)]
		public void SetTime_SimpleTimes(int hour, int min)
		{
			Time time = new Time(4, 4);
			time.SetTime(hour, min);
			Assert.Equal(hour, time.Hour);
			Assert.Equal(min, time.Minute);
		}

		[Theory]
		[InlineData(24, 60)]
		[InlineData(-1, -1)]
		[InlineData(int.MaxValue, int.MaxValue)]
		[InlineData(int.MinValue, int.MinValue)]
		public void SetTime_ArgumentException(int h, int m)
		{
			Time time = new Time(4, 4);
			Assert.Throws<ArgumentException>(() => time.SetTime(h, m));
		}









		// GetString24Time will not be tested because testing it would be basically testing C#
		// Same with GetHour and any other Get methods
	}
}
