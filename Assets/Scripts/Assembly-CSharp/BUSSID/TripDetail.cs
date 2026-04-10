using System;
using System.Collections.Generic;

namespace BUSSID
{
	[Serializable]
	public class TripDetail
	{
		public string sourceCity;

		public string destinationCity;

		public List<string> routePassed;

		public int routeCompleted;

		public TripDetail()
		{
		}

		public TripDetail(string sourceCity, string destinationCity, List<string> routePassed)
		{
		}
	}
}
