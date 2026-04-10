using BusSimulator.Modules.Driver;

namespace BUSSID
{
	public class PassengerSystemBridge : PassengerSystemBridgeBase
	{
		private static DriverSystem _driverSystem => null;

		private void Awake()
		{
		}

		public static void Init(bool isContinue)
		{
		}

		public static void SaveData()
		{
		}

		public override int GetTotalPassengersInBus()
		{
			return 0;
		}
	}
}
