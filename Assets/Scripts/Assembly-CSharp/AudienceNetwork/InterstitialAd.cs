using System;
using UnityEngine;

namespace AudienceNetwork
{
	public sealed class InterstitialAd : IDisposable
	{
		private readonly int uniqueId;

		private bool isLoaded;

		private AdHandler handler;

		public FBInterstitialAdBridgeCallback interstitialAdDidLoad;

		public FBInterstitialAdBridgeCallback interstitialAdWillLogImpression;

		public FBInterstitialAdBridgeErrorCallback interstitialAdDidFailWithError;

		public FBInterstitialAdBridgeCallback interstitialAdDidClick;

		public FBInterstitialAdBridgeCallback interstitialAdWillClose;

		public FBInterstitialAdBridgeCallback interstitialAdDidClose;

		public FBInterstitialAdBridgeCallback interstitialAdActivityDestroyed;

		public string PlacementId { get; private set; }

		public FBInterstitialAdBridgeCallback InterstitialAdDidLoad
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeCallback InterstitialAdWillLogImpression
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeErrorCallback InterstitialAdDidFailWithError
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeCallback InterstitialAdDidClick
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeCallback InterstitialAdWillClose
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeCallback InterstitialAdDidClose
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBInterstitialAdBridgeCallback InterstitialAdActivityDestroyed
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public InterstitialAd(string placementId)
		{
		}

		~InterstitialAd()
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

		public bool Show()
		{
			return false;
		}

		public void SetExtraHints(ExtraHints extraHints)
		{
		}

		internal void ExecuteOnMainThread(Action action)
		{
		}

		public static implicit operator bool(InterstitialAd obj)
		{
			return false;
		}
	}
}
