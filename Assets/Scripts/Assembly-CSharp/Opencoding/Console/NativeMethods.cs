using Opencoding.Shared.Utils;

namespace Opencoding.Console
{
	internal static class NativeMethods
	{
		public static void SendEmail(Email email)
		{
		}

		public static void CopyTextToClipboard(string text)
		{
		}

		public static bool CanSendEmail()
		{
			return false;
		}

		public static float GetNativeScreenScaleFactor()
		{
			return 0f;
		}
	}
}
