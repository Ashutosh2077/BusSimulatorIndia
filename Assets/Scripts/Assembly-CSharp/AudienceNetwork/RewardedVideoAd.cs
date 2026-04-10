using System;
using UnityEngine;

namespace AudienceNetwork
{
	public sealed class RewardedVideoAd : IDisposable
	{
		private readonly int uniqueId;

		private bool isLoaded;

		private AdHandler handler;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdDidLoad;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdWillLogImpression;

		public FBRewardedVideoAdBridgeErrorCallback rewardedVideoAdDidFailWithError;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdDidClick;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdWillClose;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdDidClose;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdComplete;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdDidSucceed;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdDidFail;

		public FBRewardedVideoAdBridgeCallback rewardedVideoAdActivityDestroyed;

		public string PlacementId { get; private set; }

		public RewardData RewardData { get; private set; }

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdDidLoad
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdWillLogImpression
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeErrorCallback RewardedVideoAdDidFailWithError
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdDidClick
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdWillClose
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdDidClose
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdComplete
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdDidSucceed
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdDidFail
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public FBRewardedVideoAdBridgeCallback RewardedVideoAdActivityDestroyed
		{
			internal get
			{
				return null;
			}
			set
			{
			}
		}

		public RewardedVideoAd(string placementId)
		{
		}

		public RewardedVideoAd(string placementId, RewardData rewardData)
		{
		}

		~RewardedVideoAd()
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

		public static implicit operator bool(RewardedVideoAd obj)
		{
			return false;
		}
	}
}
