using System.IO;
using YamlDotNet.Serialization;

namespace JobTrackerLibrary
{
	public static class YamlToUser
	{
		public static User User(string yaml)
		{
			Deserializer deserializer = new Deserializer();
			return deserializer.Deserialize<User>(yaml);
		}
	}
}
