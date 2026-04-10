namespace AudienceNetwork
{
	internal class AdSettingsBridge : IAdSettingsBridge
	{
		public static readonly IAdSettingsBridge Instance;

		internal AdSettingsBridge()
		{
		}

		static AdSettingsBridge()
		{
		}

		private static IAdSettingsBridge CreateInstance()
		{
			return null;
		}

		public virtual void AddTestDevice(string deviceID)
		{
		}

		public virtual void SetUrlPrefix(string urlPrefix)
		{
		}

		public virtual void SetMixedAudience(bool mixedAudience)
		{
		}

		public virtual void SetDataProcessingOptions(string[] dataProcessingOptions)
		{
		}

		public virtual void SetDataProcessingOptions(string[] dataProcessingOptions, int country, int state)
		{
		}

		public virtual string GetBidderToken()
		{
			return null;
		}
	}
}
