using UnityEngine;

namespace AudienceNetwork
{
	internal class AdViewBridgeListenerProxy : AndroidJavaProxy
	{
		private AdView adView;

		private readonly AndroidJavaObject bridgedAdView;

		public AdViewBridgeListenerProxy(AdView adView, AndroidJavaObject bridgedAdView)
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

		private void onLoggingImpression(AndroidJavaObject ad)
		{
		}
	}
}
