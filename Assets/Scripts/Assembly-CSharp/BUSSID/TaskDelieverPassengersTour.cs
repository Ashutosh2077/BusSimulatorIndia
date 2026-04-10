using GameplayEvent;

namespace BUSSID
{
	public class TaskDelieverPassengersTour : TaskDelieverPassengers
	{
		public static TaskDelieverPassengersTour Create(string locationId, string pointId, string fromLocationId, string fromPointId)
		{
			return null;
		}

		public static TaskDelieverPassengersTour Create(string locationId, string pointId, TaskReachTarget prevReachTargetTask)
		{
			return null;
		}

		public override void OnStart()
		{
		}

		public override void OnRouteSceneLoaded()
		{
		}

		private void UpdateSpawners()
		{
		}

		protected override void OnPassengersPicked()
		{
		}

		protected override void OnPassengersDropped()
		{
		}

		private void OnDriverReturnToBus(ExitDriverMode e)
		{
		}

		private void OnFinalPickupPassengersFromLandmark()
		{
		}
	}
}
