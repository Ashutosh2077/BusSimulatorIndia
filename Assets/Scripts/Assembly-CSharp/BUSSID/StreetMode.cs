using System;
using System.Collections.Generic;
using UIEvent;
using UnityEngine.UI;

namespace BUSSID
{
	public class StreetMode : GameModeBUSSID
	{
		public static StreetMode Instance;

		private string _passengerDataKey;

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

		public override void ResetState()
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

		public override bool IsStreet()
		{
			return false;
		}

		public static float CalculateFullRouteDistance()
		{
			return 0f;
		}

		private static float CalculateRouteListDistance(List<Location> route)
		{
			return 0f;
		}

		public override string FirebaseModeName()
		{
			return null;
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

		public override void FillCompleteText(ShowIncomePopupUI e, Text infoText)
		{
		}

		public override bool CanContinueGameWithAnotherVehicle()
		{
			return false;
		}

		public override float CalculateRevenuePotential()
		{
			return 0f;
		}

		public override bool UseBackendToResetFuel()
		{
			return false;
		}
	}
}
