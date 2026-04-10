using System.Collections.Generic;
using UnityEngine;

namespace AudienceNetwork
{
	internal class RewardedVideoAdBridgeAndroid : RewardedVideoAdBridge
	{
		private static Dictionary<int, RewardedVideoAdContainer> rewardedVideoAds;

		private static int lastKey;

		private AndroidJavaObject RewardedVideoAdForUniqueId(int uniqueId)
		{
			return null;
		}

		private RewardedVideoAdContainer RewardedVideoAdContainerForUniqueId(int uniqueId)
		{
			return null;
		}

		private string GetStringForuniqueId(int uniqueId, string method)
		{
			return null;
		}

		private string GetImageURLForuniqueId(int uniqueId, string method)
		{
			return null;
		}

		public override int Create(string placementId, RewardData rewardData, RewardedVideoAd rewardedVideoAd)
		{
			return 0;
		}

		public override int Load(int uniqueId)
		{
			return 0;
		}

		public override int Load(int uniqueId, string bidPayload)
		{
			return 0;
		}

		public override bool IsValid(int uniqueId)
		{
			return false;
		}

		public override bool Show(int uniqueId)
		{
			return false;
		}

		public override void SetExtraHints(int uniqueId, ExtraHints extraHints)
		{
		}

		public override void Release(int uniqueId)
		{
		}

		public override void OnLoad(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public override void OnImpression(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public override void OnClick(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public override void OnError(int uniqueId, FBRewardedVideoAdBridgeErrorCallback callback)
		{
		}

		public override void OnWillClose(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public override void OnDidClose(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}

		public override void OnActivityDestroyed(int uniqueId, FBRewardedVideoAdBridgeCallback callback)
		{
		}
	}
}
