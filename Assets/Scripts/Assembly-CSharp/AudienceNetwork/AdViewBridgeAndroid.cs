using System.Collections.Generic;
using UnityEngine;

namespace AudienceNetwork
{
	internal class AdViewBridgeAndroid : AdViewBridge
	{
		private static Dictionary<int, AdViewContainer> adViews;

		private static int lastKey;

		private AndroidJavaObject AdViewForAdViewId(int uniqueId)
		{
			return null;
		}

		private AdViewContainer AdViewContainerForAdViewId(int uniqueId)
		{
			return null;
		}

		private string GetStringForAdViewId(int uniqueId, string method)
		{
			return null;
		}

		private string GetImageURLForAdViewId(int uniqueId, string method)
		{
			return null;
		}

		private AndroidJavaObject JavaAdSizeFromAdSize(AdSize size)
		{
			return null;
		}

		public override int Create(string placementId, AdView adView, AdSize size)
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

		public override bool Show(int uniqueId, double x, double y, double width, double height)
		{
			return false;
		}

		public override void SetExtraHints(int uniqueId, ExtraHints extraHints)
		{
		}

		public override void Release(int uniqueId)
		{
		}

		public override void OnLoad(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public override void OnImpression(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public override void OnClick(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}

		public override void OnError(int uniqueId, FBAdViewBridgeErrorCallback callback)
		{
		}

		public override void OnFinishedClick(int uniqueId, FBAdViewBridgeCallback callback)
		{
		}
	}
}
