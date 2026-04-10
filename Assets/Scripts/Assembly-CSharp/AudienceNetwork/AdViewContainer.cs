using UnityEngine;

namespace AudienceNetwork
{
	internal class AdViewContainer
	{
		internal AndroidJavaProxy listenerProxy;

		internal AndroidJavaObject bridgedAdView;

		internal AdView adView { get; set; }

		internal FBAdViewBridgeCallback onLoad { get; set; }

		internal FBAdViewBridgeCallback onImpression { get; set; }

		internal FBAdViewBridgeCallback onClick { get; set; }

		internal FBAdViewBridgeErrorCallback onError { get; set; }

		internal FBAdViewBridgeCallback onFinishedClick { get; set; }

		internal AdViewContainer(AdView adView)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator bool(AdViewContainer obj)
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
