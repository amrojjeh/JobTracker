using Xunit;

namespace JobTrackerLibrary.Tests
{
	public class FormattedTimeTests
	{
		[Fact]
		public void GetString12Time_ShouldWork()
		{
			Time time = new Time(15, 30);
			Assert.Equal("03:30 PM", FormattedTime.Get12Time(time));
		}

		[Fact]
		public void GetString12Time_00()
		{
			Time time = new Time(0, 0);
			Assert.Equal("12:00 AM", FormattedTime.Get12Time(time));
		}

		[Fact]
		public void GetString12Time_24()
		{
			Time time = new Time(23, 59);
			Assert.Equal("11:59 PM", FormattedTime.Get12Time(time));
		}

		[Fact]
		public void GetString12Time()
		{
			Time time = new Time(12, 48);
			Assert.Equal("12:48 PM", FormattedTime.Get12Time(time));
		}
	}
}
