using UnityEngine;

namespace AudienceNetwork
{
	internal class RewardedVideoAdBridgeListenerProxy : AndroidJavaProxy
	{
		private RewardedVideoAd rewardedVideoAd;

		private readonly AndroidJavaObject bridgedRewardedVideoAd;

		public RewardedVideoAdBridgeListenerProxy(RewardedVideoAd rewardedVideoAd, AndroidJavaObject bridgedRewardedVideoAd)
			: base((string)null)
		{
		}

		private void onError(AndroidJavaObject ad, AndroidJavaObject error)
		{
		}

		private void onAdLoaded(AndroidJavaObject ad)
		{
		}

		private void onAdClicked(AndroidJavaObject ad)
		{
		}

		private void onRewardedVideoDisplayed(AndroidJavaObject ad)
		{
		}

		private void onRewardedVideoClosed()
		{
		}

		private void onRewardedVideoCompleted()
		{
		}

		private void onRewardServerSuccess()
		{
		}

		private void onRewardServerFailed()
		{
		}

		private void onLoggingImpression(AndroidJavaObject ad)
		{
		}

		private void onRewardedVideoActivityDestroyed()
		{
		}
	}
}
