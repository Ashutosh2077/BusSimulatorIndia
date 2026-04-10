using CodeStage.AntiCheat.ObscuredTypes;

namespace BUSSID
{
	public class TaskArrivedWithPassengers : TaskBase
	{
		protected string careerToken;

		protected ObscuredInt totalPassengerDropped;

		protected ObscuredInt totalFare;

		protected int totalActivityBonus;

		protected int totalCompletedActivities;

		protected Location departureLocation;

		protected Location destinationLocation;

		protected TripRecord completedTrip;

		public bool isRouteEnd;

		private int achievementSessionTime;

		private bool receivePaymentInProcess;

		private bool bonusTaken;

		protected static PlayerController _playerController => null;

		protected static GameController _gameController => null;

		protected void ShowIncomeWindow()
		{
		}

		private void ReceivePayment()
		{
		}

		private string FarePaymentSimple(int earning)
		{
			return null;
		}

		private void WatchRewardedAd()
		{
		}

		private void OnVideoRewarded()
		{
		}

		private void PopRetryDialog()
		{
		}

		private void ShowPopupFareFailed(int result = -1)
		{
		}

		public static void ShowCompleteUI()
		{
		}
	}
}
