using System;
using System.IO;
using YamlDotNet.Serialization;

namespace JobTrackerLibrary
{
	public static class UserToYaml
	{
		public static string Yaml(User user)
		{
			Serializer serializer = new Serializer();
			return serializer.Serialize(user);
		}
	}
}
