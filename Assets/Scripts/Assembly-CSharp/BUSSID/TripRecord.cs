using System;

namespace BUSSID
{
	[Serializable]
	public class TripRecord
	{
		public string destinationCity;

		public int totalPassengersDropped;

		public int totalFares;
	}
}
