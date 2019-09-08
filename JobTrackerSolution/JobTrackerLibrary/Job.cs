using System.Collections.Generic;
using System;

namespace JobTrackerLibrary
{
	public class Job : IEquatable<Job>
	{
		public string JobName { get; private set; } = "";
		public List<Log> Logs { get; private set; } = new List<Log>();

		public Job()
		{
			JobName = "Job";
		}

		public Job(string name)
		{
			if (name.Trim() == "") throw new ArgumentException("Names can't be blank");
			SetName(name);
		}

		public void SetName(string name)
		{
			JobName = name;
		}

		public void AddLog(Log log)
		{
			if (OverlappingLogException(log))
				throw new ArgumentException("Cannot set a log that takes place during another log in the same job", "log");
			Logs.Add(log);
		}

		public bool OverlappingLogException(Log log)
		{
			return Find(x => log.Date == x.Date && ((x.Start < log.End && x.Start >= log.Start) || (x.End > log.Start && x.End <= log.End))) != null;
		}

		public void RemoveLog(Log log)
		{
			Logs.Remove(log);
		}

		public void ForEach(Action<Log> action)
		{
			Logs.ForEach(action);
		}

		public Log Find(Predicate<Log> predicate)
		{
			return Logs.Find(predicate);
		}

		public override string ToString()
		{
			return JobName;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;

			Job job = obj as Job;
			if (job == null) return false;

			return Equals(job);
		}

		public override int GetHashCode()
		{
			return JobName.GetHashCode();
		}

		public bool Equals(Job other)
		{
			if (other == null) return false;
			return other.JobName == JobName;
		}
	}
}
