using Xunit;
using System;

namespace JobTrackerLibrary.Tests
{
	public class JobTests
	{
		[Theory]
		[InlineData("McDonalds - Server")]
		[InlineData("McDonalds - Manager")]
		[InlineData("Burger King - Server")]
		public static void SetName_ShouldWork(string name)
		{
			Job job = new Job("Janitor");
			job.SetName(name);
			Assert.Equal(name, job.JobName);
		}

		[Fact]
		public static void AddLog_Single()
		{
			Job job = new Job("Janitor");

			Time start = new Time(3, 30);
			Time end = new Time(23, 30);
			Log log = new Log(2023, 12, 5, start, end);

			job.AddLog(log);

			Assert.Equal(log, job.Find((l) => l.Equals(log)));
		}

		[Fact]
		public static void AddLog_Many()
		{
			Job job = new Job("Janitor");

			Time start = new Time(3, 30);
			Time end = new Time(23, 30);
			Log[] logs = new Log[1000];

			for (int x = 0; x < 1000; ++x)
			{
				logs[x] = new Log(x + 1, x % 12 + 1, x % 28 + 1, start, end);
				job.AddLog(logs[x]);
			}

			for (int x = 0; x < 1000; ++x)
			{
				Assert.Equal(logs[x], job.Find(l => l.Equals(logs[x])));
			}
		}

		[Fact]
		public static void AddLog_SameOverlappingException()
		{
			Time start = new Time(3, 30);
			Time end = new Time(23, 30);
			Log log1 = new Log(2019, 2, 28, start, end);

			Job job = new Job("Janitor");
			job.AddLog(log1);
			Assert.Throws<ArgumentException>(() => job.AddLog(log1));
		}

		[Theory]
		[InlineData(3, 30, 4, 0, 2, 30, 3, 40)]
		[InlineData(3, 30, 4, 0, 3, 31, 4, 40)]
		public static void AddLog_DifferentOverlappingException(int starth, int startm, int endh, int endm,
			int start2h, int start2m, int end2h, int end2m)
		{
			Time start = new Time(starth, startm);
			Time end = new Time(endh, endm);
			Log log1 = new Log(2019, 2, 28, start, end);

			Time start2 = new Time(start2h, start2m);
			Time end2 = new Time(end2h, end2m);
			Log log2 = new Log(2019, 2, 28, start2, end2);

			Job job = new Job("Janitor");
			job.AddLog(log1);
			Assert.Throws<ArgumentException>(() => job.AddLog(log2));
		}
	}
}
