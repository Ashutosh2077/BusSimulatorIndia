using System;
using UnityEngine;

namespace AudienceNetwork
{
	public sealed class AdView : IDisposable
	{
		private readonly int uniqueId;

		private bool isLoaded;

		private readonly AdSize size;

		private AdHandler handler;

		public FBAdViewBridgeCallback adViewDidLoad;

		public FBAdViewBridgeCallback adViewWillLogImpression;

		public FBAdViewBridgeErrorCallback adViewDidFailWithError;

		public FBAdViewBridgeCallback adViewDidClick;

		public FBAdViewBridgeCallback adViewDidFinishClick;

		public string PlacementId { get; private set; }

		public FBAdViewBridgeCallback AdViewDidLoad
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBAdViewBridgeCallback AdViewWillLogImpression
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBAdViewBridgeErrorCallback AdViewDidFailWithError
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBAdViewBridgeCallback AdViewDidClick
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBAdViewBridgeCallback AdViewDidFinishClick
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public AdView(string placementId, AdSize size)
		{
		}

		~AdView()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool iAmBeingCalledFromDisposeAndNotFinalize)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Register(GameObject gameObject)
		{
		}

		public void LoadAd()
		{
		}

		public void LoadAd(string bidPayload)
		{
		}

		public bool IsValid()
		{
			return false;
		}

		internal void LoadAdFromData()
		{
		}

		private static double HeightFromType(AdView instance, AdSize size)
		{
			return 0.0;
		}

		public bool Show(AdPosition position)
		{
			return false;
		}

		public bool Show(double y)
		{
			return false;
		}

		public bool Show(double x, double y)
		{
			return false;
		}

		private bool Show(double x, double y, double width, double height)
		{
			return false;
		}

		public void SetExtraHints(ExtraHints extraHints)
		{
		}

		internal void ExecuteOnMainThread(Action action)
		{
		}

		public static implicit operator bool(AdView obj)
		{
			return false;
		}
	}
}
