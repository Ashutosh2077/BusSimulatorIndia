namespace AudienceNetwork
{
	internal static class AdLogger
	{
		private enum AdLogLevel
		{
			None = 0,
			Notification = 1,
			Error = 2,
			Warning = 3,
			Log = 4,
			Debug = 5,
			Verbose = 6
		}

		private static AdLogLevel logLevel;

		private static readonly string logPrefix;

		internal static void Log(string message)
		{
		}

		internal static void LogWarning(string message)
		{
		}

		internal static void LogError(string message)
		{
		}

		private static string LevelAsString(AdLogLevel logLevel)
		{
			return null;
		}
	}
}
