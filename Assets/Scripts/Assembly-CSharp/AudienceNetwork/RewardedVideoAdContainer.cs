using UnityEngine;

namespace AudienceNetwork
{
	internal class RewardedVideoAdContainer
	{
		internal AndroidJavaProxy listenerProxy;

		internal AndroidJavaObject bridgedRewardedVideoAd;

		internal AndroidJavaObject rewardData;

		internal RewardedVideoAd rewardedVideoAd { get; set; }

		internal FBRewardedVideoAdBridgeCallback onLoad { get; set; }

		internal FBRewardedVideoAdBridgeCallback onImpression { get; set; }

		internal FBRewardedVideoAdBridgeCallback onClick { get; set; }

		internal FBRewardedVideoAdBridgeErrorCallback onError { get; set; }

		internal FBRewardedVideoAdBridgeCallback onDidClose { get; set; }

		internal FBRewardedVideoAdBridgeCallback onWillClose { get; set; }

		internal FBRewardedVideoAdBridgeCallback onComplete { get; set; }

		internal FBRewardedVideoAdBridgeCallback onDidSucceed { get; set; }

		internal FBRewardedVideoAdBridgeCallback onDidFail { get; set; }

		internal RewardedVideoAdContainer(RewardedVideoAd rewardedVideoAd)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator bool(RewardedVideoAdContainer obj)
		{
			return false;
		}

		internal AndroidJavaObject LoadAdConfig(string bidPayload)
		{
			return null;
		}

		public void Load()
		{
		}

		public void Load(string bidPayload)
		{
		}
	}
}
