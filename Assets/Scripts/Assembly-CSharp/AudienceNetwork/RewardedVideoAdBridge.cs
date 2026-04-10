namespace AudienceNetwork
{
	internal class RewardedVideoAdBridge : IRewardedVideoAdBridge
	{
		public static readonly IRewardedVideoAdBridge Instance;

		internal RewardedVideoAdBridge()
		{
		}

		static RewardedVideoAdBridge()
		{
		}

		private static IRewardedVideoAdBridge CreateInstance()
		{
			return null;
		}

		public virtual int Create(string placementId, RewardData rewardData, RewardedVideoAd RewardedVideoAd)
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

		public virtual bool Show(int uniqueId)
		{
			return false;
		}

		public virtual void SetExtraHints(int uniqueId, ExtraHints extraHints)
		{
		}

		public virtual void Release(int uniqueId)
		{
		}

		public virtual void OnLoad(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnImpression(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnClick(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnError(int uniqueId, FBRewardedVideoAdBridgeErrorCallback callback)
		{
		}

		public virtual void OnWillClose(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnDidClose(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnComplete(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnDidSucceed(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnDidFail(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public virtual void OnActivityDestroyed(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}
	}
}
