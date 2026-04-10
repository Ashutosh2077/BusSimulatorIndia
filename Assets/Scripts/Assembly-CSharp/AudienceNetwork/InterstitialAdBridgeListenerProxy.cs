using UnityEngine;

namespace AudienceNetwork
{
	internal class InterstitialAdBridgeListenerProxy : AndroidJavaProxy
	{
		private InterstitialAd interstitialAd;

		private readonly AndroidJavaObject bridgedInterstitialAd;

		public InterstitialAdBridgeListenerProxy(InterstitialAd interstitialAd, AndroidJavaObject bridgedInterstitialAd)
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

		private void onInterstitialDisplayed(AndroidJavaObject ad)
		{
		}

		private void onInterstitialDismissed(AndroidJavaObject ad)
		{
		}

		private void onLoggingImpression(AndroidJavaObject ad)
		{
		}

		private void onInterstitialActivityDestroyed()
		{
		}
	}
}
