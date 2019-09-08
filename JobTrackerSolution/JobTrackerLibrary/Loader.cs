using System.IO;

namespace JobTrackerLibrary
{
	public static class Loader
	{
		public static string Load(string Fullpath)
		{
			if (!File.Exists(Fullpath)) return "";
			string content;
			using (StreamReader stringReader = new StreamReader(Fullpath))
				content = stringReader.ReadToEnd();
			return content;
		}
	}
}
