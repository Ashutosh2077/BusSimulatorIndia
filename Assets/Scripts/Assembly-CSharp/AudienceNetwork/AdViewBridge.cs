namespace AudienceNetwork
{
	internal class AdViewBridge : IAdViewBridge
	{
		public static readonly IAdViewBridge Instance;

		internal AdViewBridge()
		{
		}

		static AdViewBridge()
		{
		}

		private static IAdViewBridge CreateInstance()
		{
			return null;
		}

		public virtual int Create(string placementId, AdView AdView, AdSize size)
		{
			return 0;
		}

		public virtual int Load(int uniqueId)
		{
			return 0;
		}

		public virtual int Load(int uniqueId, string bidPayload)
		{
			return 0;
		}

		public virtual bool IsValid(int uniqueId)
		{
			return false;
		}

		public virtual bool Show(int uniqueId, double x, double y, double width, double height)
		{
			return false;
		}

		public virtual void SetExtraHints(int uniqueId, ExtraHints extraHints)
		{
		}

		public virtual void Release(int uniqueId)
		{
		}

		public virtual void OnLoad(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public virtual void OnImpression(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public virtual void OnClick(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public virtual void OnError(int uniqueId, FBAdViewBridgeErrorCallback callback)
		{
		}

		public virtual void OnFinishedClick(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}
	}
}
