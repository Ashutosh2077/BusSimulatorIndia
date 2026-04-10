namespace BUSSID
{
	public class TaskDeliverPassengersCareer : TaskDelieverPassengers
	{
		public static TaskDeliverPassengersCareer Create(string locationId, string pointId, string fromLocationId, string fromPointId)
		{
			return null;
		}

		public static TaskDeliverPassengersCareer Create(string locationId, string pointId, TaskReachTarget prevReachTargetTask)
		{
			return null;
		}

		protected override void OnPassengersDropped()
		{
		}
	}
}
