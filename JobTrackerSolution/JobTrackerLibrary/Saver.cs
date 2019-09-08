using System.IO;

namespace JobTrackerLibrary
{
	public static class Saver
	{
		public static int Save(string content, string path)
		{
			if (!Directory.Exists(Path.GetDirectoryName(path)))
				return -1; // Path doesn't exist

			using (StreamWriter stream = new StreamWriter(path))
			{
				stream.Write(content);
				stream.Flush();
			}
			return 0; // Ran successfully
		}
	}
}
