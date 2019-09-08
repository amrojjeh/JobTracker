using System;
using System.Collections.Generic;

namespace JobTrackerLibrary
{
	public class User : IEquatable<User>
	{
		public string Username = "";
		public HashSet<Job> Jobs { get; set; } = new HashSet<Job>();

		public User()
		{

		}

		public User(string userName)
		{
			Username = userName;
		}

		public override bool Equals(object obj) // DO NOT USE EQUALS TO CHECK CHANGES
		{
			if (obj is null) return false;
			if (obj is User user) return Equals(user);
			return false;
		}

		public override int GetHashCode()
		{
			return Username.GetHashCode() + Jobs.GetHashCode();
		}

		public bool Equals(User other)
		{
			if (other is null) return false;
			return other.Username == Username;
		}
	}
}
