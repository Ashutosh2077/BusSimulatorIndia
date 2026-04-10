using System.Collections.Generic;
using UnityEngine;

namespace AudienceNetwork
{
	internal class InterstitialAdBridgeAndroid : InterstitialAdBridge
	{
		private static Dictionary<int, InterstitialAdContainer> interstitialAds;

		private static int lastKey;

		private AndroidJavaObject InterstitialAdForuniqueId(int uniqueId)
		{
			return null;
		}

		private InterstitialAdContainer InterstitialAdContainerForuniqueId(int uniqueId)
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

		public override int Create(string placementId, InterstitialAd interstitialAd)
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

		public override void Release(int uniqueId)
		{
		}

		public override void SetExtraHints(int uniqueId, ExtraHints extraHints)
		{
		}

		public override void OnLoad(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}

		public override void OnImpression(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}

		public override void OnClick(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}

		public override void OnError(int uniqueId, FBInterstitialAdBridgeErrorCallback callback)
		{
		}

		public override void OnWillClose(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}

		public override void OnDidClose(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}

		public override void OnActivityDestroyed(int uniqueId, FBInterstitialAdBridgeCallback callback)
		{
		}
	}
}
