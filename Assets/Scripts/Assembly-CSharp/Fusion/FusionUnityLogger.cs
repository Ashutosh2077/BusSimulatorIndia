using System;
using System.Text;
using UnityEngine;

namespace Fusion
{
	[Serializable]
	public class FusionUnityLogger : ILogger
	{
		private StringBuilder _builder;

		public bool UseGlobalPrefix;

		public bool UseColorTags;

		public string GlobalPrefixColor;

		public Color32 MinRandomColor;

		public Color32 MaxRandomColor;

		public Color ServerColor;

		public Func<object, int> GetColor { get; set; }

		public void Log<T>(LogType logType, string prefix, ref T context, string message) where T : ILogBuilder
		{
		}

		public void LogException<T>(string prefix, ref T context, Exception ex) where T : ILogBuilder
		{
		}

		private int GetRandomColor(int seed)
		{
			return 0;
		}

		private static int GetRandomColor(int seed, Color32 min, Color32 max, Color32 svr)
		{
			return 0;
		}

		private static int Color32ToRGB24(Color32 c)
		{
			return 0;
		}

		private static string Color32ToRGBString(Color32 c)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize()
		{
		}
	}
}
