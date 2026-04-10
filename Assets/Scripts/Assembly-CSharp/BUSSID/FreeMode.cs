using System;

namespace BUSSID
{
	public class FreeMode : GameModeBUSSID
	{
		public static FreeMode Instance;

		public override void OnStartGameButtonClick()
		{
		}

		public override void StartGame(bool isContinue = false, Action onStart = null, Action onError = null)
		{
		}

		public override bool IsTollPaid()
		{
			return false;
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

		public override bool NeedToShowSummaryOnArrive()
		{
			return false;
		}

		public override bool IsVehicleCanBeDamaged()
		{
			return false;
		}

		public override bool IsVehicleMustBeRepaired()
		{
			return false;
		}
	}
}
