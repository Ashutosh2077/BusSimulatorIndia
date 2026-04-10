using UnityEngine;

namespace AudienceNetwork
{
	internal class AdSettingsBridgeAndroid : AdSettingsBridge
	{
		public override void AddTestDevice(string deviceID)
		{
		}

		public override void SetUrlPrefix(string urlPrefix)
		{
		}

		public override void SetMixedAudience(bool mixedAudience)
		{
		}

		public override void SetDataProcessingOptions(string[] dataProcessingOptions)
		{
		}

		public override void SetDataProcessingOptions(string[] dataProcessingOptions, int country, int state)
		{
		}

		public override string GetBidderToken()
		{
			return null;
		}

		private AndroidJavaClass GetAdSettingsObject()
		{
			return null;
		}
	}
}
