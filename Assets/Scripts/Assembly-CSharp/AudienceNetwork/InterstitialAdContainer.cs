using UnityEngine;

namespace AudienceNetwork
{
	internal class InterstitialAdContainer
	{
		internal AndroidJavaProxy listenerProxy;

		internal AndroidJavaObject bridgedInterstitialAd;

		internal InterstitialAd interstitialAd { get; set; }

		internal FBInterstitialAdBridgeCallback onLoad { get; set; }

		internal FBInterstitialAdBridgeCallback onImpression { get; set; }

		internal FBInterstitialAdBridgeCallback onClick { get; set; }

		internal FBInterstitialAdBridgeErrorCallback onError { get; set; }

		internal FBInterstitialAdBridgeCallback onDidClose { get; set; }

		internal FBInterstitialAdBridgeCallback onWillClose { get; set; }

		internal FBInterstitialAdBridgeCallback onActivityDestroyed { get; set; }

		internal InterstitialAdContainer(InterstitialAd interstitialAd)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator bool(InterstitialAdContainer obj)
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
