using System;
using System.Collections.Generic;
using UIEvent;
using UnityEngine.UI;

namespace BUSSID
{
	public class TourMode : GameModeBUSSID
	{
		public static TourMode Instance;

		public TourData currentTour;

		public List<TourData> bakedTourListData;

		private JsonDatabase.TourState _lastTourState;

		private string _passengerDataKey;

		protected string _tourStateKey;

		public string cachedLastRefreshDate;

		public TourSaveSerializer serializedTourList;

		public string loadedTourListData;

		public void ShowPopupDataBroken()
		{
		}

		public override void LoadGameplayState()
		{
		}

		protected override void Save(string key)
		{
		}

		public override void SaveState()
		{
		}

		public override void SetState()
		{
		}

		public override void OnStartGameButtonClick()
		{
		}

		public override void StartGame(bool isContinue = false, Action onStart = null, Action onError = null)
		{
		}

		public override void StartGameLocally()
		{
		}

		public override void ResetState()
		{
		}

		public void ResetDataTourList()
		{
		}

		private void LoadAllTourData()
		{
		}

		public string GetDepartureCity(TourData tourData)
		{
			return null;
		}

		public void SaveDataTourList()
		{
		}

		public void LoadDataTourList()
		{
		}

		public void SaveDataTourListToCloud(string _data)
		{
		}

		public string GetSavedStartSpawnerId()
		{
			return null;
		}

		public void SaveStartSpwnerId(string id, string locID)
		{
		}

		public void SetTour(TourData data)
		{
		}

		public override bool IsPayFuelExchange()
		{
			return false;
		}

		public override bool IsPayToll()
		{
			return false;
		}

		public override bool IsPayBuyFuel()
		{
			return false;
		}

		public override bool IsPayCrane()
		{
			return false;
		}

		public override string FirebaseModeName()
		{
			return null;
		}

		public override bool DisplayWorldMapAreaButton()
		{
			return false;
		}

		public override void FillCompletePopup(CareerInfoMenuContainer popup)
		{
		}

		public override void FillCompleteText(ShowIncomePopupUI e, Text infoText)
		{
		}

		public override bool UsePassengerSystem()
		{
			return false;
		}

		public override int GetTotalPassengersInBus()
		{
			return 0;
		}

		public override bool UseRewardedAdToPayTol()
		{
			return false;
		}

		public override bool IsTour()
		{
			return false;
		}

		public override bool CanContinueGameWithAnotherVehicle()
		{
			return false;
		}

		public override void ShowContinueGamePopup(Action ContinueGameplay, Action ShowConfirm)
		{
		}

		public override bool WorldMapClickLocked()
		{
			return false;
		}

		public override bool UseBackendToResetFuel()
		{
			return false;
		}

		public override void OnSceneLoaded(bool isFirstLoadedScene)
		{
		}
	}
}
