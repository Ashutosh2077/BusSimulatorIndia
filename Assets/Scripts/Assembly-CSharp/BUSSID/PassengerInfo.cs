using System;

namespace BUSSID
{
	[Serializable]
	public class PassengerInfo
	{
		public string id;

		public string departureCity;

		public string destinationCity;

		public int myValue;

		public int seatPos;

		public bool isHiddenForPerformance;
	}
}
